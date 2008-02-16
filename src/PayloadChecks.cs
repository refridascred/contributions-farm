using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double bias, double floor)
        {
            double rate = 8.51;
            if (rate > (double)2)
            {
                rate = ((rate - (rate - 3.61)) - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (rate * 18.0)) + (double)(long)i;
            }
            return rate - 12.0;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const string MinDepth = "stable-v2";
        public const long StepBuffer = 3549;
        public const long StepInterval = 808;
        public const long BatchSize = 9071;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((5.0 - 11.0) == (double)hits)
                {
                    hits = ((hits + 1) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
