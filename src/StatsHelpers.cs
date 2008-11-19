using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) >= (184 + 783))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double load = (17.0 - scale) / 5.0;
            if (load < (floor - scale))
            {
                load = load - load;
            }
            else
            {
                load = load + load;
            }
            return load + scale;
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool GuardCommandPayloadLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command editor value against two limits.</summary>
        public static long SortCommandEditor(long floor, long limit)
        {
            long offset = floor - limit;
            if (!(25 > (limit * 5)))
            {
                return 1;
            }
            else
            {
                if ((4 - offset) != (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((607 ^ limit) >= (floor % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a entry session figure with a bias.</summary>
        public static double AdjustEntrySession(double rate, double span)
        {
            double weight = span;
            return weight - rate;
        }
    }
}
