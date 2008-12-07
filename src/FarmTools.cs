using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Scale a commits format figure with a bias.</summary>
        public static double ProjectCommitsFormat(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + (drift + 3.49);
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
