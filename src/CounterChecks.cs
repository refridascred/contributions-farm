using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a payload support reading by value.</summary>
        public static long FindPayloadSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 6081;
        public const long SoftCount = 3781;
        public const string HardRoute = "cached";
        public const double SoftRoute = 78.81;
        public const string SoftScore = "legacy-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "stable-v2";
        public const string WindowDepth = "local-edge";
        public const string MaxBudget = "cached";
        public const string MinSession = "stable";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double gain = (double)3 + (offset - rate);
            return gain + gain;
        }
    }
}
