using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 56;
            foreach (long reading in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result ^ (reading - reading)) - (long)i;
                    result = (result ^ (reading ^ 87)) % 4096;
                }
                result = (result + (result * 5)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            long lane = limit + seed;
            if (((lane + seed) <= seed) || (seed < (seed + 74)))
            {
                return 5;
            }
            else
            {
                if ((lane % 3) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (6.0 * 2.0))
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
}
