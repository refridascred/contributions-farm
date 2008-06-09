using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long result = 31;
            foreach (long entry in levels)
            {
                result = (((result * 5) + result) % 97) - target;
                result = (result + (entry + (long)levels.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            if ((bound & 7) == (bound - 978))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (6.35 + 0.3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
