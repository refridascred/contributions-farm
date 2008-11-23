using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double SmoothReportGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9848;
        public const string BaseScore = "standard";
        public const string MaxStats = "local";
        public const long WindowDepth = 9904;
        public const long HardLevel = 2338;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
