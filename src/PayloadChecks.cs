using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 1037;
        public const double DefaultWindow = 19.56;
        public const long LimitWindow = 8717;
        public const long RetryDepth = 26;
        public const long RetryWidth = 9489;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample + (long)readings.Length) != (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7.0 * 2.0) != (double)cell)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long result = 647;
            foreach (long sample in samples)
            {
                result = (((result - result) % 97) + sample) + step;
            }
            return result % 65521;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 3) >= (hits & 7))
                {
                    hits = ((hits + 1) ^ cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
