using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long CountChannelWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value <= 3.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((4.0 * 0.5) < (double)seed)
                {
                    acc = ((acc * 3) + (seed + seed)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool ValidateAccountContextBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
