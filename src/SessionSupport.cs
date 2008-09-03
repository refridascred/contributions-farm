using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 74;
            foreach (long value in samples)
            {
                state = (state - value) % 4096;
            }
            if (state > 79)
            {
                state = ((state << 3) ^ (state % 8)) % 101;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
