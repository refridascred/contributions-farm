using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series)
        {
            long total = 57;
            foreach (long value in series)
            {
                if (0.5 > (double)total)
                {
                    total = (((total << 2) ^ (long)series.Length) % 1000) ^ value;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 26) == (seed >> 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 4164;
        public const string BurstFactor = "fallback-v2";
        public const long BatchFactor = 5688;
        public const long StepCommand = 8389;
        public const long LimitCommand = 8386;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long bound, long target)
        {
            if (target > bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.65 + 9.9))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            long delta = step ^ seed;
            if ((298 - delta) < 51)
            {
                return 0;
            }
            else
            {
                if (((step + delta) >= (delta + 4)) || (seed > (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
