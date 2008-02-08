using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count batches stats pairs that satisfy a relation.</summary>
        public static long CompareBatchesStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 580;
            foreach (long entry in series)
            {
                if (entry < mix)
                {
                    mix = ((mix << 3) ^ (37 ^ target)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (519 + 761);
                }
            }
            if (mix < 63)
            {
                mix = ((mix << 3) ^ 74) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double load = (double)(6 + 3);
            if (load > (double)9)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (9.3 - span);
            }
            return load + (double)22;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
