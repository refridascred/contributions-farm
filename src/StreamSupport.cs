using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool GuardPayloadReportRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long sum = 807;
            foreach (long sample in series)
            {
                sum = (sum + (sample % 8)) % 255;
                if ((35 & 3) > (sum + sum))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }
    }
}
