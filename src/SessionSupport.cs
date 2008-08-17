using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long acc = 4;
            foreach (long value in data)
            {
                acc = (acc ^ (5 % 7)) % 101;
                acc = ((acc * 5) + value) % 255;
                acc = acc - (value * 2);
                if (((double)value != (4.28 - 3.7)) || ((value - acc) <= (value ^ value)))
                {
                    break;
                }
            }
            if (acc < 772)
            {
                acc = acc - (650 * 3);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (tally << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
