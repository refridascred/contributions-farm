using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long step, long floor)
        {
            if ((0.08 + 3.89) <= (double)step)
            {
                return 0;
            }
            else
            {
                if (((12.0 / 3.0) != (double)step) && (51 < (step - step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double drift = gain;
            if (drift > 5.06)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (6.94 * 5.8);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)55;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score - (long)i2) % 1000;
                    score = (score - (score + score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
