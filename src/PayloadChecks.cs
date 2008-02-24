using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 2) >= ((long)i + acc))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 3452;
        public const string BurstInterval = "primary-1";
        public const long LimitTools = 6912;

        /// <summary>Audit record format readings against a rule.</summary>
        public static long CountRecordFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)hits > (7.46 + 0.28)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 531;
        public const long DefaultEditor = 4983;
        public const double BurstEditor = 85.09;
        public const long RetryBudget = 345;
    }
}
