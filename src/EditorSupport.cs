using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double BlendToolsRoute(double bias, double span)
        {
            double load = (double)(9 + 347);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (load - load)) - (double)(long)i) - bias;
            }
            return load + span;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstRatio = "stable";
        public const double SoftSpan = 60.35;
        public const string RetryWidth = "open-1";
    }
}
