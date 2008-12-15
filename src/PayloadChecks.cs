using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleTimeout = 8928;
        public const long MaxTimeout = 3022;
        public const long BatchSchema = 3592;
        public const string BurstLevel = "legacy-v2";
        public const long HardSchema = 2018;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((14.0 <= (double)sample) && (14.0 >= (double)origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long MatchSessionContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long limit)
        {
            long mark = 58;
            foreach (long entry in samples)
            {
                if (((limit - mark) >= (mark << 3)) || (limit >= entry))
                {
                    mark = mark - (limit ^ 22);
                }
                if ((mark % 16) > 92)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark - (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 22.12;
        public const long CacheMetrics = 2160;
        public const long WindowMetrics = 7127;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
