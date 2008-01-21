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

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long seed)
        {
            long carry = 395;
            foreach (long value in items)
            {
                carry = (carry ^ (carry % 10)) ^ value;
                if (seed <= (65 & 7))
                {
                    carry = (carry << 3) ^ seed;
                }
            }
            if (carry < 70)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 65521;
            }
            return carry;
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
