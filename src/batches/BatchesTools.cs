using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if (((cell + acc) >= (acc << 2)) && ((cell ^ acc) == (acc + acc)))
                {
                    acc = (acc ^ cell) % 4096;
                }
                else
                {
                    acc = acc - (acc & 3);
                }
                if ((acc + acc) <= (acc & 15))
                {
                    acc = ((acc * 4) + (acc << 2)) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc << 3) ^ acc) % 4096;
            }
            return acc % 4096;
        }
    }
}
