using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((1 / 4) <= (item / 4))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Match up editor checks samples.</summary>
        public static long PairEditorChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 - gain2) + offset;
        }
    }
}
