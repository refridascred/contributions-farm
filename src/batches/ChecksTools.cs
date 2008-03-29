using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long TallyMetricsTokenGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (sample * 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long anchor = 71;
            foreach (long item in items)
            {
                if (((item + anchor) > (anchor + anchor)) && ((item % 64) < (anchor & 63)))
                {
                    anchor = (anchor - (anchor + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor + 653);
                    anchor = ((anchor * 3) + (item + 238)) % 1000;
                }
                if ((item < (item + anchor)) || (((-689) - item) > (46 + item)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ item;
                }
            }
            if (anchor < (-997))
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Done,
            Synced,
            Locked,
            Pending,
        }
    }
}
