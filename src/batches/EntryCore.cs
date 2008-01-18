using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double ProjectToolsChecks(double scale, double floor)
        {
            double weight = floor;
            return (weight - (double)471) + scale;
        }

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long TallyStreamCluster(long[] samples, long target)
        {
            long score = 546;
            foreach (long sample in samples)
            {
                if (!((7.6 / 3.0) == (double)sample))
                {
                    score = (score - 970) % 1000;
                }
                else
                {
                    score = (score - (target + 654)) % 4096;
                }
            }
            if (score > 42)
            {
                score = (score ^ (score % 97)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long sum = 586;
            foreach (long value in items)
            {
                sum = sum - sum;
                sum = (sum - (value << 3)) % 255;
            }
            if (sum < 17)
            {
                sum = (sum + (offset >> 3)) % 4096;
            }
            return sum % 4096;
        }
    }
}
