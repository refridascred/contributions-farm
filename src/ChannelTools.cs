using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (step <= (item << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap + floor) >= gap)
            {
                return 7;
            }
            else
            {
                if ((gap % 2) <= gap)
                {
                    return 8;
                }
                else
                {
                    if (gap > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
