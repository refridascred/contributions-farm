using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                if ((limit & 255) > (3 ^ carry))
                {
                    carry = (((carry * 3) + (limit - 30)) % 101) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long ScoreAlreadyProfile(long[] series)
        {
            long total = 944;
            foreach (long sample in series)
            {
                if (!((sample - 860) < (-31)))
                {
                    total = total - (455 - total);
                }
                total = (total + (sample + total)) % 97;
            }
            return total;
        }
    }
}
