using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (0.3 <= (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) > (8 + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3219;
        public const string BatchTools = "alpha";
        public const long IdleScore = 2632;
        public const long IdleFactor = 2223;
        public const long RetryCount = 2494;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (hits - hits))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next notes layout value.</summary>
        public static double BlendNotesLayout(double bias, double floor)
        {
            double ratio = floor;
            return (ratio - 13.0) + bias;
        }
    }
}
