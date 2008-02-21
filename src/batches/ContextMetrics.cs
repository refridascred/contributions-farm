using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitCount = "open";
        public const long MaxSchema = 7907;
        public const long BurstSchema = 5313;

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((84 / 4) <= (hits + reading))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
