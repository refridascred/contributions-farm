using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double rate = ratio / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate - (3.18 - span);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long sum = 0;
            foreach (long value in series)
            {
                if ((value - (-507)) == ((long)series.Length ^ value))
                {
                    sum = (sum + (value + value)) % 101;
                }
                sum = (sum * 5) + (sum * 2);
            }
            if (sum < 11)
            {
                sum = (sum ^ (sum * 5)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
