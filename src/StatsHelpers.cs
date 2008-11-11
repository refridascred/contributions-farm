using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + origin;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            New,
            Failed,
            Pending,
            Draft,
        }
    }
}
