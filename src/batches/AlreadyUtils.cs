using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long floor)
        {
            if (((floor + origin) >= 167) || ((1 << 1) != ((-8) ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((origin & 7) != (floor - 82))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) <= (floor & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue account entries that pass the check.</summary>
        public static long TallyQueueAccountMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell + cell) > cell) || (cell >= (matches * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item & 3) < (sum >> 5))
                {
                    sum = (sum ^ (7 + item)) % 65521;
                }
            }
            if (sum > 513)
            {
                sum = ((sum << 3) ^ (sum - origin)) % 101;
            }
            return sum;
        }
    }
}
