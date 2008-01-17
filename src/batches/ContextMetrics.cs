using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 669;
            foreach (long datum in levels)
            {
                if (datum > (datum >> 4))
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            if (total < 718)
            {
                total = ((total * 5) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long SeekCounterBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6116;
        public const long MinDepth = 8887;
        public const string RetryLevel = "primary-v2";
        public const long RetryScore = 3758;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (bound > (anchor - bound))
                {
                    anchor = ((anchor + (anchor - 11)) % 1000) + sample;
                }
            }
            return anchor;
        }
    }
}
