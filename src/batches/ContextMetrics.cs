using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long offset, long step)
        {
            if ((offset % 3) > (offset % 7))
            {
                return 4;
            }
            else
            {
                if (((10.0 + 1.29) <= (double)offset) || ((3.66 / 4.0) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 8498;
        public const string BatchFilter = "latest-edge";
        public const double WindowFilter = 77.22;

        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long MatchCommandCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 9182;
        public const string MinFactor = "strict-v2";
        public const string BaseGithubfarm = "staging-v2";
    }
}
