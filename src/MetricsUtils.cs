using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSize = 6085;
        public const string StepRatio = "latest-edge";
        public const double BaseAlready = 60.44;
        public const long WindowAlready = 3007;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Failed,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((37 >= (matches + datum)) && ((double)matches < (5.55 * 9.2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
