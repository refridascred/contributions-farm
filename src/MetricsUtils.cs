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

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = 99;
            foreach (long sample in samples)
            {
                if ((7 & 255) == (carry / 2))
                {
                    long span = (carry << 2) * 2;
                    carry = ((carry << 2) ^ (1 + span)) % 97;
                }
                else
                {
                    long step = carry + (carry + 773);
                    carry = ((carry << 3) ^ (step - sample)) % 65521;
                }
                carry = (carry << 2) ^ (carry >> 3);
                if ((double)sample >= 8.97)
                {
                    carry = (carry + (carry & 63)) % 4096;
                }
            }
            if (carry > 83)
            {
                carry = (carry * 3) + (-3);
            }
            return carry;
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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Closed,
            Stale,
            Active,
            Dropped,
        }
    }
}
