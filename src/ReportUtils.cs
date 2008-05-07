using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values)
        {
            long sum = 739;
            foreach (long item in values)
            {
                long gap = item % 10;
                if (((306 + gap) >= (sum % 60)) && (4 > (32 - gap)))
                {
                    gap = gap - (gap * 2);
                }
                sum = ((sum * 4) + (long)values.Length) % 101;
            }
            if (sum < 8)
            {
                sum = sum - (sum / 9);
            }
            return sum;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((66 + (long)i) <= ((long)i - (long)i))
                {
                    carry = (carry << 2) ^ (carry & 7);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 97;
                    anchor = (anchor - (anchor + (long)i2)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
