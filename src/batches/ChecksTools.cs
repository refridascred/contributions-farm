using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next stream cluster value.</summary>
        public static double SmoothStreamCluster(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= ratio)
            {
                ratio = (ratio + (4.4 * 15.0)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (8.0 * 4.7)) + (double)(long)i;
            }
            return ratio + 11.0;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Ready,
            Closed,
            New,
            Pending,
        }

        /// <summary>Accumulate cache entry samples.</summary>
        public static long CombineCacheEntry(long[] data, long seed)
        {
            long anchor = 66;
            foreach (long datum in data)
            {
                if ((double)datum <= 2.8)
                {
                    anchor = ((anchor - anchor) % 65521) + seed;
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum << 2);
                }
            }
            if (anchor > (-47))
            {
                anchor = ((anchor * 2) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 * 1.07) > (double)offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
