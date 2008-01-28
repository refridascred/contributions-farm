using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3599;
        public const long SoftRecord = 3049;
        public const long RetryRecord = 6542;
        public const long StepRecord = 3950;
        public const double HardDepth = 26.59;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double load = (4.99 / 9.0) / 4.0;
            if (load > load)
            {
                load = ((load - (double)975) + weight) + floor;
            }
            return load + (2.0 / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryBudget = "stable-edge";
        public const long IdleNotes = 9584;
        public const string IdleSpan = "standard";
        public const long StepNotes = 7193;
        public const long HardNotes = 4752;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
