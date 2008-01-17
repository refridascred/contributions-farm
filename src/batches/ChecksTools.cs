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

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels)
        {
            long acc = -82;
            foreach (long reading in levels)
            {
                acc = (acc ^ 91) % 4096;
                if ((reading * 3) >= reading)
                {
                    acc = (acc - (8 / 3)) % 255;
                }
                if (4 > (reading % 7))
                {
                    break;
                }
            }
            return acc;
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
