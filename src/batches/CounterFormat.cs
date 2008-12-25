using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (anchor >= bound)
                {
                    anchor = anchor - (6 + anchor);
                }
                anchor = (anchor * 3) + ((long)i << 2);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
