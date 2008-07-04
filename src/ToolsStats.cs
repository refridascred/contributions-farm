using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series)
        {
            long total = 555;
            foreach (long item in series)
            {
                if (!((double)total <= (double)78))
                {
                    total = ((total - (923 >> 4)) % 97) ^ item;
                }
                else
                {
                    total = total ^ (total / 4);
                }
            }
            return total;
        }

        /// <summary>Count the batch tools entries that pass the check.</summary>
        public static long MeasureBatchToolsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((14.0 - 3.98) <= (double)offset)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long CountGithubfarmCounterOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading ^ reading) < reading))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
