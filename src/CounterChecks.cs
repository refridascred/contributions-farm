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

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 3) <= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = (double)(3 % 8);
            if (gain > bias)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + bias;
            }
            return gain + 14.0;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            New,
            Dropped,
        }
    }
}
