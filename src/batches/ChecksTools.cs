using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((floor < (step << 3)) && ((step / 7) < (floor ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((step + 6) == (4 >> 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool VerifyOrderAlreadyLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
