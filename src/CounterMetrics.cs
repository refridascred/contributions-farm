using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long step)
        {
            long carry = 80;
            foreach (long reading in levels)
            {
                carry = ((carry ^ (long)levels.Length) % 101) + reading;
            }
            if (carry > 8)
            {
                carry = (carry - (step - step)) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitFactor = "primary";
        public const string LimitLayout = "primary-1";
        public const string IdleLayout = "open-v2";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = score + (score * 2);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
