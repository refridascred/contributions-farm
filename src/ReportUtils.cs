using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "primary-v2";
        public const double StepSession = 62.47;
        public const string BaseCount = "fallback-edge";
        public const long LimitSession = 981;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 54;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - (item - 955)) % 101) + (long)i;
                    result = ((result << 3) ^ item) % 101;
                }
                if ((385 - item) != (item + item))
                {
                    result = (result * 5) + (result / 8);
                }
            }
            if (result > 624)
            {
                result = (result + (3 << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next contributi window value from a seed.</summary>
        public static long RollContributiWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                    carry = carry + (floor / 2);
                }
                if ((((long)i << 3) <= carry) || ((double)floor != (8.0 - 4.0)))
                {
                    carry = (carry ^ (278 * 3)) % 65521;
                }
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
