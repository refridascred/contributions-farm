using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Closed,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                long step = floor;
                long prev = (mix / 3) - (mix / 4);
                if ((prev & 3) < prev)
                {
                    step = ((step * 5) + (650 ^ mix)) % 1000;
                }
                else
                {
                    mix = (mix ^ (step >> 1)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepWidth = "open-edge";
        public const double CacheRatio = 23.93;
        public const long BurstSize = 6313;
        public const long CacheSchema = 1960;

        /// <summary>Blend two command batch measurements.</summary>
        public static double SmoothCommandBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean < (mean - bias))
            {
                mean = mean + (double)8;
            }
            return mean + 9.6;
        }
    }
}
