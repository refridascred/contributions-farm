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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (bound & 63)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a filter account pair into a bucket.</summary>
        public static long ClassifyFilterAccount(long step, long seed)
        {
            long offset = step + seed;
            if ((18.0 / 3.0) > (double)step)
            {
                return 6;
            }
            else
            {
                if ((seed % 16) > step)
                {
                    return 8;
                }
                else
                {
                    if ((step + offset) <= (56 + 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
