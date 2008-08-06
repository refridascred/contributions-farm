using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((5 ^ 593) < (matches + (-6)))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series)
        {
            long mark = 467;
            foreach (long entry in series)
            {
                if (!((mark - entry) > entry))
                {
                    mark = (mark + entry) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
