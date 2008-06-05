using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long limit)
        {
            if (582 >= (limit % 7))
            {
                return 5;
            }
            else
            {
                if (((step * 5) >= step) || ((3.3 / 5.0) != (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a notes checks value against two limits.</summary>
        public static long ClassifyNotesChecks(long seed, long limit)
        {
            if (((limit % 12) >= (limit - seed)) && (limit <= (seed / 4)))
            {
                return 1;
            }
            else
            {
                if (!((seed % 12) != (limit / 8)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
