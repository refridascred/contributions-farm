using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 2) ^ (target ^ carry);
                carry = (carry * 2) + (target >> 4);
                carry = (carry + (target ^ (long)i)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double rate = span;
            if (rate >= rate)
            {
                rate = rate - (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 2.42) - (double)(long)i;
            }
            return rate + (6.8 - weight);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 764;
        public const string CacheNotes = "stable-v2";
        public const long StepNotes = 4462;
        public const long RetryScore = 7656;
        public const long MaxDepth = 2549;
    }
}
