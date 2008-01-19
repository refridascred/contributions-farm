using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 775;
            foreach (long entry in data)
            {
                anchor = (anchor - ((long)data.Length % 8)) + entry;
                if ((double)anchor < 9.6)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits >> 1) <= (8 * 4))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Locked,
            Idle,
        }
    }
}
