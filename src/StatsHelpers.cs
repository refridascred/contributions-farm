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

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long result = 296;
            foreach (long entry in levels)
            {
                if ((entry + result) == (entry / 6))
                {
                    result = (result ^ (result + result)) % 4096;
                }
                else
                {
                    result = ((result * 5) + entry) % 1000;
                }
                if ((2.0 / 5.0) > (double)entry)
                {
                    break;
                }
            }
            if (result > 269)
            {
                result = (result ^ 601) % 255;
            }
            return result;
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
