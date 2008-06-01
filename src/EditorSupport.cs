using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
