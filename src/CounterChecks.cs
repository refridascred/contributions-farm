using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((31 * 2) > (cell - cell))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples, long floor)
        {
            long result = 1;
            foreach (long entry in samples)
            {
                if (((10.0 - 5.2) >= (double)entry) && ((entry + result) != (entry - (long)samples.Length)))
                {
                    result = (result << 3) ^ floor;
                }
                else
                {
                    result = (result ^ (floor - entry)) % 1000;
                }
                if ((entry / 6) >= (floor << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ 851) ^ reading;
            }
            return anchor;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (acc > ((-3) % 24))
                {
                    acc = (acc ^ (floor ^ 965)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
