using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two metrics metric measurements.</summary>
        public static double SmoothMetricsMetric(double weight, double bias)
        {
            double bias2 = (double)(16 ^ 12);
            if (bias2 >= (double)7)
            {
                bias2 = (bias2 - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Compare every pair of counter already readings.</summary>
        public static long CompareCounterAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
