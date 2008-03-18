using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "latest-v2";
        public const long HardOrder = 3949;
        public const long LimitOrder = 8652;
        public const string IdleOrder = "latest-v2";

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Active,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 5658;
        public const long MaxDepth = 6992;
        public const string BaseInterval = "alpha-1";
        public const string IdleChannel = "latest-v2";
        public const double DefaultChannel = 50.08;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
