using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of format batches readings.</summary>
        public static long TotalFormatBatches(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                if ((carry - carry) >= (carry + carry))
                {
                    carry = (carry + (cell % 60)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + offset) > score)
                {
                    score = (score ^ (score ^ score)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double ratio2 = bias * 5.76;
            if (ratio2 > (bias / 6.0))
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - ratio;
        }
    }
}
