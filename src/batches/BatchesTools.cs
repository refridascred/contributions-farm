using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 486;
        public const long SoftCommits = 5073;
        public const long LimitCommits = 7222;
        public const string BurstCommits = "alpha-v2";
        public const long BatchCount = 415;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value + (-5)) == (offset % 97)) && ((3.23 - 9.9) == (double)offset))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
