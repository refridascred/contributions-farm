using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (floor & 255)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((2.0 <= (double)count) && !((count << 1) > (count - 53)))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            New,
            Closed,
        }
    }
}
