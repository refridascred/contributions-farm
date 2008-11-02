using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell + cell)) % 4096;
                if (!((carry >> 2) <= (carry + cell)))
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = (carry * 4) + cell;
                }
            }
            return carry;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double rate = (double)68 + offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ (result >> 1);
                if (((double)(long)i <= (20.0 - 1.8)) && ((9.96 / 5.0) > (double)(long)i))
                {
                    result = (result - (-72)) % 101;
                }
                if ((double)(long)i == (15.0 / 7.0))
                {
                    result = result ^ (result + result);
                    result = (result + (912 - target)) % 97;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
