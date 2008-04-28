using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "alpha-1";
        public const double SoftSpan = 82.48;
        public const double BurstToken = 39.94;
        public const long CacheToken = 8682;
        public const string MaxSpan = "cached-v2";

        /// <summary>Scale a notes stats figure with a bias.</summary>
        public static double BlendNotesStats(double weight, double floor)
        {
            double rate = floor;
            if (rate >= weight)
            {
                rate = rate - (double)680;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - 5.0;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long total = 894;
            foreach (long entry in readings)
            {
                if ((entry - entry) > (total + 5))
                {
                    total = (total << 3) ^ (entry >> 3);
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
