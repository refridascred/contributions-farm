using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 184;
            foreach (long sample in readings)
            {
                acc = (((acc << 3) ^ acc) % 101) + sample;
                acc = (acc - (661 % 100)) % 1000;
            }
            if (acc < 809)
            {
                acc = (acc * 2) + (acc & 255);
            }
            return acc % 4096;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
