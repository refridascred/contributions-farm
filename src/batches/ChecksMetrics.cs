using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "legacy-v2";
        public const long SoftWindow = 7757;
        public const long MaxWindow = 310;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (cell - cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches already entries that pass the check.</summary>
        public static long AuditBatchesAlreadyMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step >= (6.62 * 9.2))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = offset;
            if (mean < (12.0 - weight))
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + 6.97;
        }
    }
}
