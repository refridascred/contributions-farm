using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = carry;
                carry = (carry + (carry ^ next)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long limit)
        {
            long total = 0;
            foreach (long item in values)
            {
                if ((4 ^ 2) == (total >> 2))
                {
                    total = ((total * 4) + (total >> 2)) - limit;
                }
                else
                {
                    total = total - (item ^ (long)values.Length);
                }
            }
            if (total < 1)
            {
                total = (total - (total * 5)) % 1000;
            }
            return total;
        }
    }
}
