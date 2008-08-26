using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 90.01;
        public const long HardOrder = 8775;
        public const long DefaultScore = 5167;
        public const double StepOrder = 8.34;
        public const long WindowOrder = 534;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSize = 4662;
        public const long SoftGithubfarm = 4978;
        public const long HardDepth = 6955;
        public const long IdleTimeout = 5245;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)datum >= (4.0 + 6.1)) || ((datum + matches) <= (datum + (long)series.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long limit2)
        {
            if ((double)limit2 <= (1.54 + 6.01))
            {
                return 0;
            }
            else
            {
                if ((0.6 + 8.2) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
