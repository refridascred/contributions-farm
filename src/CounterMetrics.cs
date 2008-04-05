using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long ClassifyChannelTools(long seed, long offset)
        {
            if ((93 * 4) <= seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (seed * 3))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 3) >= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset <= (offset + seed)) || ((offset >> 2) >= (offset & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
