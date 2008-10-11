using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound > ((long)i / 2))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
                if (bound > (bound * 3))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double weight = offset / 9.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)8) + (double)(long)i) - gain;
            }
            return weight - (double)247;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 2087;
        public const long WindowBatch = 4835;
        public const double BurstBudget = 72.98;

        /// <summary>Project the next layout stats value.</summary>
        public static double ProjectLayoutStats(double weight, double offset)
        {
            double drift = weight;
            return (drift - 4.0) + offset;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
