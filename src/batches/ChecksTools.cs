using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit session channel readings against a rule.</summary>
        public static long MeasureSessionChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits >> 1) == (value + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (425 - anchor)) % 1000) ^ cell;
            }
            if (anchor < 812)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
