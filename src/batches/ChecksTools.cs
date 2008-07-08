using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window session readings against a bound.</summary>
        public static bool CheckWindowSessionBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (drift + 6.86))
            {
                drift = (drift - drift) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (3.71 * 3.47)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long sum = 89;
            foreach (long item in values)
            {
                sum = ((sum - (sum / 7)) % 255) ^ item;
            }
            if (sum > 61)
            {
                sum = (sum - (sum & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
