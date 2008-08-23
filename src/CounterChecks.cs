using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long sum = 11;
            foreach (long item in data)
            {
                if (!((double)item <= (double)7))
                {
                    sum = ((sum * 3) + item) % 97;
                }
                sum = sum - item;
            }
            if (sum > 157)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSpan = 4573;
        public const long MaxTools = 2146;
        public const string BatchTools = "alpha-v2";
        public const double IdleSize = 21.74;
        public const long BurstTools = 4439;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5123;
        public const long RetryEntry = 3501;
        public const long SoftLevel = 3649;

        /// <summary>Locate a window farm reading by value.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
