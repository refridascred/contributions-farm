using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((-22) > sample)
                {
                    total = ((total + sample) % 1000) + target;
                }
            }
            return total;
        }
    }
}
