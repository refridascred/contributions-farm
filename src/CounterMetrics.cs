using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double mean = scale * 17.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + span)) + (double)(long)i;
            }
            return mean + (double)7;
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long AuditPayloadRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry - tally) < (entry << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
