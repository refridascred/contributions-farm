using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long origin)
        {
            if ((15.0 - 6.3) == (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin <= (seed & 15)) && (origin < seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ acc) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long origin)
        {
            if (!((8 - origin) == (50 % 60)))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (0.21 - 9.5)) && ((origin / 2) <= (origin * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= 5)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
