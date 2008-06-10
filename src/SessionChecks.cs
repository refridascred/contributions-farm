using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stream format samples.</summary>
        public static long CombineStreamFormat(long[] levels, long offset)
        {
            long result = 7;
            foreach (long item in levels)
            {
                if (((offset * 5) < (item >> 3)) && ((98 << 2) < result))
                {
                    result = (result + (item >> 1)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (7 / 5)) % 101;
                }
            }
            if (result < 98)
            {
                result = result + (38 & 3);
            }
            return result % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally ^ reading))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
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
    }
}
