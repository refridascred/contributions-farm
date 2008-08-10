using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits >= (8.1 + 3.4)) && ((6.7 + 3.3) <= (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
