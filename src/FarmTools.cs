using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Queued,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next profile format value from a seed.</summary>
        public static long IterateProfileFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score - ((-2) % 97)) % 97;
                if ((567 + score) < (score + score))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
