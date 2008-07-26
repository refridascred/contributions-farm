using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (target <= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter notes series from a seed.</summary>
        public static long StepFilterNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((152 - 5) != (58 + matches))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 37.01;
        public const long DefaultChannel = 2688;
        public const double MaxSpan = 94.77;
        public const long IdleCount = 2417;
    }
}
