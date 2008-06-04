using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (double)(9 << 1);
            if (weight < (bias / 9.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)709;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((8.4 / 7.0) < (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long WeighFarmRoute(long[] items)
        {
            long score = -1;
            foreach (long cell in items)
            {
                if ((cell % 12) > (cell + score))
                {
                    score = (score << 2) ^ (score - 645);
                }
                else
                {
                    score = (score - score) % 1000;
                }
                if (score < (cell + cell))
                {
                    score = score - cell;
                }
            }
            if (score < 54)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double rate = (double)(7 + 542);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (bias * 2.31)) + (double)(long)i) + weight;
            }
            return rate - rate;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
