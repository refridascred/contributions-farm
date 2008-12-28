using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3053;
        public const long LimitTimeout = 1827;
        public const string LimitScore = "open";
        public const string MinToken = "alpha-1";

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double weight = (double)4 / 3.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - (19.0 - bias2)) + (double)(long)i) - bias;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long carry = 947;
            foreach (long reading in items)
            {
                if ((double)bound != (double)carry)
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 65521;
                    carry = carry ^ (bound + 67);
                    continue;
                }
                carry = (carry - (reading ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftDepth = 9953;
        public const long SoftRatio = 2322;
        public const string MaxCount = "legacy";
        public const long RetryWidth = 394;
    }
}
