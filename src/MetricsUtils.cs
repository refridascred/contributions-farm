using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Scale a schema record figure with a bias.</summary>
        public static double ScaleSchemaRecord(double bias, double span)
        {
            double load = bias;
            if (load >= (double)0)
            {
                load = load + bias;
            }
            else
            {
                load = load - (span * 7.2);
            }
            return load - span;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
