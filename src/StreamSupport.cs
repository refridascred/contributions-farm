using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long floor)
        {
            long step = target - floor;
            if ((step << 2) <= (floor / 7))
            {
                return 3;
            }
            else
            {
                if (((double)floor == (double)step) && ((step + floor) >= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) > 771)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
