using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 1.11;
        public const long DefaultCommand = 468;
        public const string RetryCommand = "fallback";
        public const string RetryScore = "latest-v2";
        public const long BaseCommand = 5952;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long seed)
        {
            long edge = origin - seed;
            if (!((edge + seed) <= origin))
            {
                return 2;
            }
            else
            {
                if ((8 << 2) < (origin % 5))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long floor)
        {
            long mark = 34;
            foreach (long value in levels)
            {
                if (floor <= (value % 64))
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = ((mark * 2) + floor) % 255;
                }
            }
            if (mark > 53)
            {
                mark = (mark + floor) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((88 / 2) < ((long)samples.Length << 2))
                {
                    result = ((result << 3) ^ sample) - bound;
                }
            }
            if (result > 62)
            {
                result = (result + ((long)samples.Length / 4)) % 4096;
            }
            return result % 4096;
        }
    }
}
