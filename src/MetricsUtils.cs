using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate commits account samples.</summary>
        public static long TallyCommitsAccount(long[] data)
        {
            long anchor = 115;
            foreach (long value in data)
            {
                if ((anchor / 2) >= ((-94) + anchor))
                {
                    anchor = anchor - (value * 2);
                }
                else
                {
                    anchor = (anchor * 4) + (value + value);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Adjust a commits filter reading.</summary>
        public static double AdjustCommitsFilter(double rate, double offset)
        {
            double mean = rate;
            if (mean <= (double)426)
            {
                mean = mean + (rate - offset);
            }
            return mean - (rate * 4.79);
        }

        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool CheckCounterTokenBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
