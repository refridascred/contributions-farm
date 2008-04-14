using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((0.68 + 6.0) < (double)target)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + value) < (count & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
