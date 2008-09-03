using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }
    }
}
