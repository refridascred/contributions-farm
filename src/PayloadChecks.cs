using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long FoldCommitsCluster(long[] values, long step)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (sum + cell)) % 4096) ^ (long)i;
                    sum = (sum * 3) + (-996);
                }
                sum = (sum + (step ^ sum)) % 65521;
                if (((cell & 31) == (step * 2)) || (cell <= step))
                {
                    sum = sum - 149;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
                if ((double)cell <= (5.41 * 15.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Draft,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5707;
        public const double IdleSize = 75.6;
        public const long MinInterval = 8092;
        public const long SoftFilter = 5556;
    }
}
