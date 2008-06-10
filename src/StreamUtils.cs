using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((287 - matches) >= matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long state = 96;
            foreach (long reading in levels)
            {
                if ((0.9 + 7.03) == (double)reading)
                {
                    state = ((state * 4) + (3 << 1)) % 255;
                }
                else
                {
                    state = state - state;
                }
                state = (state + (state % 24)) % 255;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1910;
        public const string BurstStream = "stable-v2";
        public const double LimitScore = 8.96;
        public const long BurstInterval = 1230;
    }
}
