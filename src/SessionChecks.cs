using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count % 97) <= (36 * 5))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long next = origin - bound;
            if (next <= (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) == (origin - next))
                {
                    return 4;
                }
                else
                {
                    if (next < (860 / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)origin < 8.5) || ((double)origin < (double)4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 5692;
        public const double LimitContext = 76.06;
        public const string MinRatio = "staging-edge";

        /// <summary>Compare every pair of profile support readings.</summary>
        public static long MatchProfileSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
