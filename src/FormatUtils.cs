using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long total = 549;
            foreach (long item in levels)
            {
                if (((609 >> 2) <= (total << 1)) || ((double)total > (2.4 + 1.3)))
                {
                    break;
                }
                else
                {
                    total = ((total << 2) ^ item) % 101;
                }
                total = (total - 6) % 97;
                if ((total + total) < 456)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((count >> 2) < ((long)items.Length % 5)))
                {
                    count = ((count + 2) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((9 <= sample) && (((step >> 2) <= (step % 10)) || ((double)seen != (9.0 / 9.0))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
