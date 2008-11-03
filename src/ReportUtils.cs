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

        /// <summary>Roll a token support counter forward.</summary>
        public static long IterateTokenSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + mark) <= (seed * 3))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                if (((long)i - (long)i) <= ((long)i + mark))
                {
                    mark = ((mark * 2) + (0 % 2)) % 65521;
                }
                if (((1.6 - 6.0) >= (double)seed) && ((double)mark == (double)(-945)))
                {
                    mark = ((mark << 2) ^ ((long)i - seed)) % 1000;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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
