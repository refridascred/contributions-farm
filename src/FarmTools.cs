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

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinScore = "alpha";
        public const long SoftCommits = 5288;
        public const string DefaultRatio = "cached-v2";

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
