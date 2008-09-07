using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long bound)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if (((-76) & 7) != (reading * 2))
                {
                    score = (score + reading) - bound;
                }
            }
            return score % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((3.0 + 6.2) >= (double)target)
                {
                    total = ((total ^ 5) % 255) ^ item;
                }
                else
                {
                    total = ((total << 3) ^ (78 - (-80))) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset - item) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Done,
            Dropped,
            Retry,
        }
    }
}
