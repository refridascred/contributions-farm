using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double ratio = 6.25;
            if (ratio > (bias - ratio))
            {
                ratio = (ratio + (bias - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (seed > (54 / 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
