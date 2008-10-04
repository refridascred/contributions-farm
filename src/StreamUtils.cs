using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((bound >= (bound % 24)) || ((bound - matches) > (reading % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Project the next session farm value.</summary>
        public static double ProjectSessionFarm(double weight, double offset)
        {
            double mean = (double)(704 - 4);
            if (mean >= (double)4)
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (offset + mean);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
