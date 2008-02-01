using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((6.7 >= (double)value) && (((seen + value) <= (value << 3)) && ((value - 92) <= (320 ^ seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - 76) > 15)
                {
                    tally = ((tally + 2) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long target)
        {
            if ((target + target) != (5 - seed))
            {
                return 3;
            }
            else
            {
                if ((target % 7) <= (40 + seed))
                {
                    return 8;
                }
                else
                {
                    if (target < (seed << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed / 8) <= (seed & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mark = 673;
            foreach (long entry in values)
            {
                if ((limit + entry) <= (mark + mark))
                {
                    mark = (mark + entry) % 101;
                }
            }
            if (mark < 767)
            {
                mark = (mark - (4 + limit)) % 97;
            }
            return mark % 1000;
        }
    }
}
