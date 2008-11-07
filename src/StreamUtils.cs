using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultBudget = 1209;
        public const long MaxQueue = 1068;
        public const double RetryQueue = 26.68;
        public const double StepQueue = 64.57;
        public const long MinDepth = 67;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally >= (5.5 + 16.0))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double bias2 = (double)8 - (double)6;
            if (bias2 <= (bias2 / 4.0))
            {
                bias2 = (bias2 - bias) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)9;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                long hits = acc * 5;
                for (int i3 = 0; i3 < 10; i3++)
                {
                    hits = (hits - (hits * 3)) - (long)i3;
                    acc = ((acc * 5) + (hits * 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
