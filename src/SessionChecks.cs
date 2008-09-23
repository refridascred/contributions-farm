using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long SortSessionCluster(long offset, long origin)
        {
            if (!((94 % 100) <= (offset % 3)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.91 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long FoldClusterGraph(long[] levels, long step)
        {
            long mix = 96;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 5) + 2) % 97) - (long)i;
                }
                mix = ((mix << 2) ^ (step % 2)) % 101;
                mix = ((mix * 4) + (25 + entry)) % 97;
                if (((1.2 - 2.0) <= (double)step) || ((entry >> 5) >= (mix - 6)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "strict-1";
        public const long WindowCache = 2118;
        public const string BurstCache = "staging-v2";
        public const long BatchDepth = 3361;
    }
}
