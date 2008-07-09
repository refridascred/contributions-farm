using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long offset)
        {
            if (!((limit / 9) < (offset / 2)))
            {
                return 8;
            }
            else
            {
                if (7.0 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long seed)
        {
            if (((seed + limit) <= 97) || ((seed & 3) >= seed))
            {
                return 0;
            }
            else
            {
                if ((double)825 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) >= (limit * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((9.33 + 9.83) < (double)seed) && (7 <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
