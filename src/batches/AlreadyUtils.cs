using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((97 + value) > value) || ((81 % 64) < (limit ^ count))) && ((value - value) != (count % 97)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long FoldClusterCommits(long[] values, long origin)
        {
            long carry = 44;
            foreach (long sample in values)
            {
                if (((15.0 / 8.0) <= (double)sample) || (7.62 >= (double)origin))
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry << 3) ^ (carry * 4)) % 1000;
            }
            return carry;
        }
    }
}
