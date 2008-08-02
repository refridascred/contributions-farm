using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double scale = rate;
            if (scale < (3.3 - rate))
            {
                scale = scale + (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (offset - 11.0);
        }

        /// <summary>Fold a list of schema filter readings.</summary>
        public static long WeighSchemaFilter(long[] items)
        {
            long state = 48;
            foreach (long cell in items)
            {
                if ((cell * 5) > (state ^ cell))
                {
                    state = (state ^ cell) % 97;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "primary-1";
        public const long IdleWidth = 628;
        public const double WindowSize = 86.04;
        public const string StepCount = "primary-edge";
        public const long LimitBatches = 1311;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
