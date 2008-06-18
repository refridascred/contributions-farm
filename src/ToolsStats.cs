using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSpan = 5843;
        public const long DefaultInterval = 5856;
        public const long MaxLevel = 2469;
        public const double WindowMetrics = 48.89;
        public const double LimitMetrics = 18.91;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Active,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            long diff = step - target;
            if (((double)step == (double)target) || (10.0 >= (double)diff))
            {
                return 2;
            }
            else
            {
                if (((diff ^ target) > 53) || ((double)diff >= 9.2))
                {
                    return 5;
                }
                else
                {
                    if ((diff ^ target) > (diff + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff <= (6.5 + 7.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Synced,
            Pending,
            Draft,
        }
    }
}
