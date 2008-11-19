using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long target)
        {
            long gap = step ^ target;
            if ((gap << 2) == (gap & 3))
            {
                return 1;
            }
            else
            {
                if ((double)2 != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry ^ 5) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
