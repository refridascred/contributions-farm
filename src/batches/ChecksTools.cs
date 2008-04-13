using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next entry command value from a seed.</summary>
        public static long SeriesEntryCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state * 3) + ((long)i << 1)) % 255) + (long)i2;
                }
                state = (state + (state * 4)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
