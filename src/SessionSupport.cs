using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next graph queue value.</summary>
        public static double BlendGraphQueue(double gain, double floor)
        {
            double mean = (double)(59 / 3);
            if (mean >= gain)
            {
                mean = mean - floor;
            }
            return mean + (double)45;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= 0.2)
            {
                drift = drift - 6.98;
            }
            else
            {
                drift = drift + (9.7 + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift - offset)) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = -2;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (score - (long)levels.Length)) - cell;
            }
            return score;
        }
    }
}
