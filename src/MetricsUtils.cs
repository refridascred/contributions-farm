using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long origin)
        {
            if ((origin + bound) >= origin)
            {
                return 7;
            }
            else
            {
                if (!((bound + origin) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (!((origin + bound) >= (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin > (origin / 2)) && ((bound + bound) >= (origin + 97)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8506;
        public const double StepScore = 43.41;
        public const long RetryCommits = 9535;
        public const long BurstBudget = 3100;
        public const long MinCommits = 8292;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
