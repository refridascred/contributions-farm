using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of batches payload entries.</summary>
        public static long WeighBatchesPayload(long[] values, long bound)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = (carry ^ (bound ^ bound)) - value;
            }
            if (carry < 73)
            {
                carry = ((carry * 4) + (carry * 4)) % 97;
            }
            return carry % 1000;
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
