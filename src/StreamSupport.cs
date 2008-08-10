using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long target)
        {
            long score = 3;
            foreach (long sample in samples)
            {
                if ((45 >= (score + target)) || (score >= (target - target)))
                {
                    score = (score << 3) ^ (2 / 3);
                    score = (score + 262) % 97;
                }
                score = (score - (76 << 1)) % 1000;
                if ((score * 2) != (sample - sample))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values, long offset)
        {
            long total = 656;
            foreach (long sample in values)
            {
                if (offset <= (170 >> 3))
                {
                    total = (total - (total + total)) ^ sample;
                }
                if (((-8) / 9) >= (offset >> 4))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total + (offset >> 2)) % 101;
            }
            return total;
        }
    }
}
