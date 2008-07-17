using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Ready,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double scale = (double)(-89) * 12.0;
            if (scale >= (double)51)
            {
                scale = (scale + (weight + scale)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 2.32) + (double)(long)i;
            }
            return scale - (double)98;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
