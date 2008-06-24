using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route session input into a small class.</summary>
        public static long RankRouteSession(long target, long origin)
        {
            long next = target ^ origin;
            if (!((target >> 5) != (target / 3)))
            {
                return 4;
            }
            else
            {
                if (next >= (origin ^ target))
                {
                    return 5;
                }
                else
                {
                    if ((origin - target) > 38)
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
