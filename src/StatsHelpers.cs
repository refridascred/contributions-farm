using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == ((long)i + seed))
                {
                    carry = (carry * 5) + (seed >> 5);
                    carry = ((carry << 2) ^ (seed % 100)) % 97;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (offset < (offset - offset))
            {
                return 1;
            }
            else
            {
                if (((seed + offset) < (seed / 2)) || ((double)seed == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 + 8.2) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-46) & 3) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((step / 9) > (hits - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)item <= (1.0 + 11.0)) || ((double)item < (7.2 - 6.1))) || !((item - item) != (0 + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
