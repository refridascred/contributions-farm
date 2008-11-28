using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
