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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const string MinDepth = "stable-v2";
        public const long StepBuffer = 3549;
        public const long StepInterval = 808;
        public const long BatchSize = 9071;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
