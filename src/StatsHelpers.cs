using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((mix - limit) > mix)
                {
                    mix = (mix + limit) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) >= (reading - reading))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
