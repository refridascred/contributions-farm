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

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxFactor = 47.51;
        public const long StepCount = 9382;
        public const double SoftChannel = 90.48;

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
