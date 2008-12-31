using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a window report figure with a bias.</summary>
        public static double BlendWindowReport(double scale, double offset)
        {
            double gain = scale + (5.93 / 6.0);
            if (gain <= gain)
            {
                gain = (gain + (scale + 4.05)) - offset;
            }
            return gain + gain;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (offset2 > (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset2 + 2) >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((618 + 67) > (datum / 5))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
