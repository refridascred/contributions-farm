using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - 0) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 5) + (mix - mix)) % 65521) - (long)i2;
                    mix = mix ^ origin;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((((sum * 2) + (sum % 24)) % 4096) ^ entry) - seed;
            }
            if (sum > 87)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 4096;
        }
    }
}
