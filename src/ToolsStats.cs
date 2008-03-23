using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Count cluster channel pairs that satisfy a relation.</summary>
        public static long CompareClusterChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long MeasureSessionGithubfarmMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.51 * 18.0) < (double)value)
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseDepth = 66.9;
        public const string BurstCommand = "local-edge";
        public const long DefaultCommand = 4591;
        public const double BaseCommand = 94.89;
        public const long StepCommand = 2822;

        /// <summary>Iterate the queue profile series from a seed.</summary>
        public static long RollQueueProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 4065;
        public const double BaseCluster = 90.04;
        public const long IdleDepth = 3858;
    }
}
