using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((392 / 4) != (limit / 2))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter filter reading.</summary>
        public static double ProjectCounterFilter(double bias, double span)
        {
            double ratio = (bias * 2.88) / 9.0;
            if (ratio > span)
            {
                ratio = ratio + (span * 8.31);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)4;
        }
    }
}
