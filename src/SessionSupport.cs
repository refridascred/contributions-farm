using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long LookupContributiBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format batches readings.</summary>
        public static long MatchFormatBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long origin)
        {
            if ((double)origin <= (17.0 - 8.0))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (((origin & 127) < (origin + offset)) && ((double)origin > (15.0 - 17.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (7.6 >= (double)offset)
                        {
                            return 5;
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
}
