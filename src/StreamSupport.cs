using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long RankBatchEditor(long seed, long limit)
        {
            if ((limit % 3) < (limit << 1))
            {
                return 2;
            }
            else
            {
                if ((12.0 * 15.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 127) > limit) || ((seed & 63) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (337 <= (6 + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of farm tools readings.</summary>
        public static long PairFarmToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
