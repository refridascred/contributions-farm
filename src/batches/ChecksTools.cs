using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Iterate the account tools series from a seed.</summary>
        public static long IterateAccountTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + (anchor + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally <= (tally ^ tally)) && (((tally + tally) >= (tally / 9)) || ((-521) >= (value * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
