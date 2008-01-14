using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double drift = 9.6;
            if (drift > rate)
            {
                drift = (drift + 12.0) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 2.0) + (double)(long)i;
            }
            return drift + 17.0;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series)
        {
            long score = 674;
            foreach (long sample in series)
            {
                if ((score << 1) < sample)
                {
                    score = score + (sample - score);
                }
                score = (score << 2) ^ (sample - sample);
            }
            if (score < 97)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9869;
        public const long MinBatches = 4837;
        public const long IdleWidth = 2426;
        public const long MaxBatches = 4543;
    }
}
