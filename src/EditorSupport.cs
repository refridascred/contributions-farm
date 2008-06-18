using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = (anchor * 3) + 33;
                anchor = anchor - datum;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 3) + (anchor + 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Rank metric queue input into a small class.</summary>
        public static long BucketMetricQueue(long target, long seed)
        {
            if (((target - (-611)) < (target + seed)) || ((seed - 215) != (seed + target)))
            {
                return 7;
            }
            else
            {
                if (((-72) + seed) >= 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
