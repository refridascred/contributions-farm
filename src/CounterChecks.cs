using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long carry = 21;
            foreach (long entry in items)
            {
                if (!((carry + entry) > (carry >> 3)))
                {
                    carry = ((carry * 2) + entry) % 101;
                }
                carry = (carry ^ (carry / 9)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstRatio = 29.46;
        public const long IdleInterval = 8519;
        public const double StepTimeout = 41.79;
        public const long MinCluster = 1293;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 6217;
        public const long HardFactor = 5073;
        public const long MaxOrder = 6890;
        public const long HardScore = 8718;
        public const long BatchTimeout = 5566;
    }
}
