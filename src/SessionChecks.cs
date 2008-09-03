using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)22)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Done,
            Stale,
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long CountGraphPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 2) > (976 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = result + (long)i3;
                }
                if (!!(result <= ((-97) << 1)))
                {
                    result = ((result * 2) + (result - (long)i)) % 65521;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
