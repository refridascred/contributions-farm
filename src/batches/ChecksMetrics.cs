using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if ((item + 49) <= (item >> 2))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc ^ reading) != (reading * 5))
                {
                    acc = (acc - acc) - floor;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 11.77;
        public const double MinWidth = 42.32;
        public const long BaseRatio = 1881;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double ratio = floor - (bias * 7.37);
            if (ratio <= (ratio * 8.8))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - (floor / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (15.0 + bias);
        }

        /// <summary>Count token entry pairs that satisfy a relation.</summary>
        public static long MatchTokenEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool VerifyCounterAlreadyBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
