using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 175;
            foreach (long value in values)
            {
                if (!((value << 1) >= (score / 6)))
                {
                    score = ((score * 3) + (score + score)) % 1000;
                }
                if (value >= (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Done,
            Dropped,
        }
    }
}
