using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = 239;
            foreach (long value in levels)
            {
                sum = (sum - (sum - sum)) % 4096;
                if (((double)sum == (9.4 + 2.3)) && ((value + value) == (626 ^ sum)))
                {
                    sum = (sum ^ (value ^ sum)) % 1000;
                }
                else
                {
                    sum = (sum - ((-655) / 2)) % 97;
                }
                if (((5.69 + 1.6) <= (double)sum) && ((double)sum > (double)value))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 514;
        public const long BaseInterval = 3089;
        public const string DefaultEditor = "local-v2";

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ carry) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
