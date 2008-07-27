using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 555;
            foreach (long value in data)
            {
                if (((4.1 / 6.0) != (double)value) && (total <= (-90)))
                {
                    total = ((total * 3) + value) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Synced,
            Queued,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
