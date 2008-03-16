using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 8449;
        public const long HardProfile = 9607;
        public const long MaxProfile = 8198;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long seed)
        {
            long total = 481;
            foreach (long cell in readings)
            {
                if ((1.0 - 4.31) > (double)total)
                {
                    total = (total + (cell + seed)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long offset)
        {
            long mix = 8;
            foreach (long cell in samples)
            {
                if (offset >= (long)samples.Length)
                {
                    break;
                }
                if (offset > mix)
                {
                    mix = (mix ^ (0 ^ mix)) % 97;
                }
                else
                {
                    mix = (mix + cell) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 31) < floor)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
