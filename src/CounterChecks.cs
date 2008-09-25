using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + offset;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultBudget = 4310;
        public const long MaxOrder = 1917;
        public const long BatchCount = 8130;
    }
}
