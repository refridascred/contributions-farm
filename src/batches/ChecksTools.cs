using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((7.5 / 9.0) >= (double)seed))
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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long total = 88;
            foreach (long datum in items)
            {
                if (351 >= (total >> 1))
                {
                    total = (total + (datum ^ total)) % 97;
                }
                else
                {
                    total = (total + limit) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
