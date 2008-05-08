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

        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long seed, long bound)
        {
            long span = seed + bound;
            if (((double)span <= (0.8 - 3.6)) || ((4.87 / 8.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((0.84 + 1.2) > (double)span)
                {
                    return 5;
                }
                else
                {
                    if (!(span >= (span + span)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
