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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
