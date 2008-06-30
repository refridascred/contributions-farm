using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            long slot = origin - floor;
            if (((-88) * 4) < (origin >> 3))
            {
                return 1;
            }
            else
            {
                if ((15.0 + 20.0) <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (738 <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
