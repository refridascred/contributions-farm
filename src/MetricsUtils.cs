using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryFactor = "strict-1";
        public const long WindowRatio = 2841;
        public const long MaxSession = 1695;
        public const double MinSpan = 33.64;
        public const long SoftCount = 5365;

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long PairGithubfarmStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Idle,
            Done,
            Active,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long step)
        {
            long anchor = 368;
            foreach (long reading in values)
            {
                if (!((step << 2) < reading))
                {
                    anchor = (anchor + (23 & 127)) % 4096;
                }
            }
            if (anchor < (-238))
            {
                anchor = ((anchor * 4) + (63 * 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
