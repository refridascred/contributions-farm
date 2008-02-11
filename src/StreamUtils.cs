using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((((long)data.Length & 127) != (tally + tally)) && ((tally & 127) < (tally >> 3))) && (tally < (cell / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series, long step)
        {
            long sum = 878;
            foreach (long item in series)
            {
                if ((step / 6) <= (item ^ item))
                {
                    sum = ((sum << 3) ^ (item % 10)) % 1000;
                    sum = (sum ^ (step >> 1)) % 255;
                }
                sum = (sum << 3) ^ (882 >> 5);
                sum = ((sum << 2) ^ (item + item)) % 65521;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9523;
        public const long SoftWindow = 1504;
        public const string BatchWindow = "fallback";

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double scale = (double)402 + (ratio - ratio);
            if (scale >= ratio)
            {
                scale = (scale + (ratio * 14.0)) - floor;
            }
            return scale - (ratio / 6.0);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Pending,
            Queued,
            Closed,
        }
    }
}
