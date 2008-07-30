using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double floor)
        {
            double rate = (weight / 8.0) / 8.0;
            if (rate <= (double)64)
            {
                rate = (rate + (weight * 7.5)) - floor;
            }
            return rate - (5.2 * 4.31);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 49.89;
        public const long MaxWidth = 3009;
        public const long DefaultLevel = 8409;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double load = rate;
            if (load <= (double)14)
            {
                load = load - (rate * 2.4);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Failed,
            Pending,
        }
    }
}
