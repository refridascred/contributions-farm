using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 4401;
        public const string BurstSpan = "open-v2";
        public const long MaxContributi = 1418;
        public const long BatchContributi = 7722;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias + load))
            {
                load = load + load;
            }
            return load - 8.0;
        }

        /// <summary>Look up the position of a record checks sample.</summary>
        public static long LocateRecordChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor * 3) + (offset ^ offset)) % 255) ^ (long)i2;
                    anchor = (anchor ^ (offset + offset)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
