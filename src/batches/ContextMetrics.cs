using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Synced,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Blend two buffer editor measurements.</summary>
        public static double SmoothBufferEditor(double weight, double span)
        {
            double bias = span;
            if (bias < (double)66)
            {
                bias = bias - 9.0;
            }
            else
            {
                bias = bias + (weight * 8.2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias + bias)) - (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Stale,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Idle,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }
    }
}
