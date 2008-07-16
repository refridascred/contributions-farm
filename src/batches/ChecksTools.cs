using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long CountAccountCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally / 2) <= ((long)values.Length * 3)) || ((double)tally <= (double)14))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Rank stats batch input into a small class.</summary>
        public static long ClassifyStatsBatch(long floor, long step)
        {
            long lane = floor - step;
            if (((double)floor >= (7.18 + 9.0)) || (step <= (lane + step)))
            {
                return 8;
            }
            else
            {
                if ((2 + step) > (step << 1))
                {
                    return 1;
                }
                else
                {
                    if (((lane - floor) < (lane / 3)) || ((lane * 2) > (floor >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
