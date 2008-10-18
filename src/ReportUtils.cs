using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long score = 97;
            foreach (long sample in readings)
            {
                if ((8 / 9) > (sample * 5))
                {
                    score = (score ^ (score + sample)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (double)(-5) / 2.0;
            if (rate <= (5.48 + scale))
            {
                rate = (rate + (rate - scale)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long bound)
        {
            long lane = seed - bound;
            if (!((bound - 96) < seed))
            {
                return 1;
            }
            else
            {
                if (seed <= (lane - bound))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
