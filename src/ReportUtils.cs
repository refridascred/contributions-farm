using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long origin)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (value >= (value & 31))
                {
                    total = (total ^ 851) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (value % 24)) % 4096;
                }
                if ((503 <= (origin ^ total)) || ((value / 8) == (total * 3)))
                {
                    total = (total ^ 26) % 101;
                }
                else
                {
                    total = (total * 2) + origin;
                }
                if (((total - total) >= (value ^ value)) || ((823 + value) <= (value - value)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardScore = "standard";
        public const long WindowBatch = 4912;
        public const long HardDepth = 5196;
        public const long DefaultBatch = 9615;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 21.58;
        public const double BatchBatches = 14.5;
        public const double RetryBatches = 90.34;
        public const string IdleBatches = "standard-1";
        public const long CacheBatches = 6784;
    }
}
