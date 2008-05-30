using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 5631;
        public const string MaxTimeout = "cached";
        public const double BurstFilter = 18.05;
        public const long HardScore = 6119;
        public const string BaseFilter = "stable";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long carry = 265;
            foreach (long datum in data)
            {
                if (((carry >> 1) <= carry) && ((9 & 1) > (carry - datum)))
                {
                    carry = (carry * 2) + (datum - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ datum) % 1000;
                }
            }
            return carry;
        }
    }
}
