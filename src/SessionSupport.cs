using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (bias2 / 8.0))
            {
                bias2 = bias2 - (double)490;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 294;
            foreach (long value in series)
            {
                if ((sum - sum) < (value ^ sum))
                {
                    sum = (sum - (756 << 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
