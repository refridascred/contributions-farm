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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools contributi samples are out of range.</summary>
        public static long AuditToolsContributiGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((seed - value) != (hits >> 2)) && !((hits - hits) < (value * 3)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
