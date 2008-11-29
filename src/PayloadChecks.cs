using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Ready,
            Active,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((double)sum > (19.0 + 10.0))
                {
                    sum = (((sum << 2) ^ (5 + sum)) % 97) + datum;
                }
            }
            if (sum > 334)
            {
                sum = (sum ^ (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8014;
        public const double WindowSpan = 32.41;
        public const long WindowChannel = 4564;
        public const string LimitInterval = "open-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 9568;
        public const string RetryInterval = "primary-edge";
        public const long IdleAccount = 9803;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)52)
            {
                weight2 = weight2 + (offset / 7.0);
            }
            else
            {
                weight2 = weight2 + (double)42;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 0.1) + (double)(long)i;
            }
            return weight2 + (double)(-8);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long total = -9;
            foreach (long item in levels)
            {
                if ((item / 3) != (item - total))
                {
                    total = ((total << 3) ^ (total >> 5)) % 97;
                    total = (total ^ (total % 7)) % 65521;
                }
                total = (total * 3) + total;
            }
            return total % 97;
        }
    }
}
