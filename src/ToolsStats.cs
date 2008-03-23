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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool ValidateRecordFarmLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
