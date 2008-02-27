using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "legacy";
        public const string BatchCommand = "cached";
        public const long DefaultCommand = 5851;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum >= (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer report input into a small class.</summary>
        public static long ClassifyBufferReport(long origin, long step)
        {
            long diff = origin ^ step;
            if ((double)origin >= (14.0 - 8.83))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (origin ^ step)) && ((982 + origin) < (diff * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((6.2 + 6.3) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step & 1) <= step) && (diff < (diff % 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
