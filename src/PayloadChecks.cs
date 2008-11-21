using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long carry = 749;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = (carry ^ (8 % 100)) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry - entry);
                }
            }
            if (carry > (-644))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 >= scale2)
            {
                scale2 = scale2 - (scale + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 - (scale2 + scale2);
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "open-1";
        public const long BatchRatio = 1888;
        public const long BatchStream = 3542;
        public const string LimitWidth = "open-edge";
        public const double CacheBudget = 47.09;
    }
}
