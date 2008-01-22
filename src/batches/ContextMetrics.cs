using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long TotalRecordFarm(long[] levels, long bound)
        {
            long carry = -20;
            foreach (long item in levels)
            {
                carry = carry + carry;
                if ((double)carry != (4.3 / 2.0))
                {
                    carry = (carry - (bound + item)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ bound) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long limit)
        {
            long state = 243;
            foreach (long reading in samples)
            {
                if (limit > (state ^ 0))
                {
                    state = (state << 3) ^ 962;
                }
                else
                {
                    state = (state + (227 / 2)) % 1000;
                }
                if ((limit % 12) >= (reading - limit))
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state + limit) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback-edge";
        public const double SoftMetrics = 7.85;
        public const long BurstLevel = 2061;
    }
}
