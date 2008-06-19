using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                long step = (mix % 60) % 24;
                mix = (mix << 3) ^ step;
                mix = ((mix * 5) + reading) % 101;
            }
            if (mix > 3)
            {
                mix = (mix - (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowInterval = 76.87;
        public const long CacheStats = 6569;
        public const double StepStats = 12.75;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 722;
            foreach (long cell in values)
            {
                total = ((total * 5) + (total % 8)) + cell;
            }
            return total;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
