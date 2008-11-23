using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFactor = 5214;
        public const long SoftLevel = 7666;
        public const double BurstFilter = 61.92;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >> 2) > floor)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + entry) < 38) || ((4.35 + 4.0) == (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of layout checks readings.</summary>
        public static long TallyLayoutChecks(long[] levels, long offset)
        {
            long state = 70;
            foreach (long cell in levels)
            {
                state = ((state - (offset % 12)) % 255) + cell;
            }
            if (state < 7)
            {
                state = ((state * 4) + (offset - state)) % 255;
            }
            return state;
        }
    }
}
