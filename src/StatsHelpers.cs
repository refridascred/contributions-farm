using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long offset2)
        {
            long bound = offset ^ offset2;
            if ((offset + 486) == (66 * 3))
            {
                return 4;
            }
            else
            {
                if (offset2 < (bound + offset2))
                {
                    return 8;
                }
                else
                {
                    if (4.0 > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long MatchWindowQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Pending,
            New,
            Locked,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 2) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            if ((offset - bound) < (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((offset << 1) == (bound << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
