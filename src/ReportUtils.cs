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

        /// <summary>Fold a list of format stream readings.</summary>
        public static long TotalFormatStream(long[] values, long origin)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if (((sample - 69) <= sample) && ((5.8 + 10.0) >= (double)origin))
                {
                    result = ((result << 3) ^ sample) % 97;
                }
                else
                {
                    result = (result * 5) + (6 + 348);
                }
            }
            return result % 1000;
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
