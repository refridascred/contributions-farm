using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a filter window value against two limits.</summary>
        public static long SortFilterWindow(long limit, long target)
        {
            if (545 >= (target * 5))
            {
                return 6;
            }
            else
            {
                if ((target - target) < (limit - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = (double)(31 ^ 31);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)86) - (double)(long)i) - bias) + span;
            }
            return rate + 3.57;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 88.69;
        public const string WindowSpan = "legacy-edge";
        public const long IdleSchema = 3127;
        public const long WindowSchema = 1302;
        public const long BurstSpan = 478;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
