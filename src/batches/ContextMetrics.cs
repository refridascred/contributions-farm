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

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long mix = 87;
            foreach (long entry in data)
            {
                if (((3.93 * 5.4) <= (double)mix) && ((5.66 - 10.0) > (double)entry))
                {
                    mix = (mix ^ (mix - entry)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }
    }
}
