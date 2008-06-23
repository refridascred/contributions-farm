using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "cached-1";
        public const string StepSize = "open-edge";
        public const double SoftTimeout = 15.0;
        public const long SoftProfile = 7982;
        public const string RetryProfile = "fallback-v2";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = -82;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (mix / 9)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
