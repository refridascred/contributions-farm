using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long bound, long floor)
        {
            if (floor <= 928)
            {
                return 6;
            }
            else
            {
                if (bound >= (bound - 470))
                {
                    return 1;
                }
                else
                {
                    if ((bound - (-2)) != (86 << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + floor) == (3 >> 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (acc - acc) % 4096;
                if ((double)limit == (double)datum)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (limit + (long)samples.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Match up already profile samples.</summary>
        public static long CompareAlreadyProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of window support readings.</summary>
        public static long CompareWindowSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
