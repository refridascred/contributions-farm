using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long offset)
        {
            long lane = target + offset;
            if (!(lane < (target << 3)))
            {
                return 4;
            }
            else
            {
                if ((13.0 + 4.3) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (lane > (target - lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset <= (6.0 - 20.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
