using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of report schema entries.</summary>
        public static long TotalReportSchema(long[] readings)
        {
            long sum = 181;
            foreach (long item in readings)
            {
                if ((-805) > (item - sum))
                {
                    sum = sum - (880 << 1);
                }
            }
            if (sum < 677)
            {
                sum = (sum << 3) ^ (506 - 9);
            }
            return sum % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = 0.31 + (floor - floor);
            if (gain < (double)2)
            {
                gain = (gain - floor) + bias;
            }
            return gain - (double)5;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8499;
        public const long MinSize = 8472;
        public const long MinScore = 2533;
        public const string CacheLevel = "stable-edge";

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
