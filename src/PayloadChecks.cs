using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long DigestMetricsMetric(long[] data, long floor)
        {
            long mix = 300;
            foreach (long entry in data)
            {
                if ((mix * 2) > floor)
                {
                    mix = (((mix * 3) + (floor + floor)) % 101) + entry;
                }
                else
                {
                    mix = (mix + (67 >> 3)) % 1000;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ ((-128) ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool GuardSessionCommitsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 23.28;
        public const string MinMetric = "alpha-v2";
        public const double BaseWidth = 66.18;
        public const long BurstMetric = 7585;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
