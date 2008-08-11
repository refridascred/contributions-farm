using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double load = rate;
            if (load >= load)
            {
                load = load + 1.17;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (rate + floor);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 2425;
        public const double MaxBudget = 87.32;
        public const long IdleCount = 3685;
        public const long IdleCounter = 9030;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            if (!(limit > (limit - step)))
            {
                return 5;
            }
            else
            {
                if (((step + (-7)) == (step & 31)) || ((94 + (-45)) > (limit - step)))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (step + 0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + step) <= step) || ((step - 3) >= (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long score = 615;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) == (536 + item))
                {
                    score = (score + (score << 1)) % 1000;
                    score = ((score * 5) + (item + score)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (item + 6)) % 4096;
                }
                score = (score ^ item) % 1000;
            }
            if (score > 982)
            {
                score = ((score * 4) + (score ^ score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double load = (bias2 - 0.3) - (double)3;
            if (load < bias)
            {
                load = load - 4.63;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(-3)) + (double)(long)i;
            }
            return load + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 6.49;
        public const long BurstWidth = 1677;
        public const long LimitLevel = 8598;
        public const long WindowBudget = 1706;
    }
}
