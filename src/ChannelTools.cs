using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + value) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long sum = 784;
            foreach (long item in series)
            {
                if (((-303) >> 5) > sum)
                {
                    sum = (((sum << 3) ^ sum) % 101) ^ item;
                }
            }
            if (sum < 582)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
