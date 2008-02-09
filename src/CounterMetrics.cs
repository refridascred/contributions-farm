using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long seed)
        {
            long anchor = 618;
            foreach (long sample in items)
            {
                anchor = (anchor << 3) ^ sample;
            }
            if (anchor < 495)
            {
                anchor = ((anchor * 4) + (91 ^ seed)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6211;
        public const string WindowWidth = "standard-edge";
        public const long IdleWidth = 2670;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long score = 395;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score ^ (step * 2)) % 4096) - (long)i) - datum;
                }
                score = (score + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)761)
            {
                ratio = (ratio - 6.5) + bias2;
            }
            return ratio + bias;
        }
    }
}
