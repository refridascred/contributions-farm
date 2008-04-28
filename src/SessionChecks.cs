using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long anchor = -136;
            foreach (long cell in values)
            {
                if (((seed * 3) <= anchor) && ((seed + 1) > anchor))
                {
                    anchor = ((anchor << 3) ^ (anchor / 5)) + cell;
                }
            }
            return anchor;
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long ClassifyStreamEditor(long origin, long target)
        {
            long cur = origin - target;
            if (((double)origin <= (double)target) && ((double)target > (8.25 + 6.5)))
            {
                return 5;
            }
            else
            {
                if (cur < (4 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur == (18.0 - 5.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((bound + item) > (tally >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
