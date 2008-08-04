using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up context stats samples.</summary>
        public static long MatchContextStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] items)
        {
            long result = 1;
            foreach (long sample in items)
            {
                if (68 < (sample + result))
                {
                    result = (result * 5) + (21 ^ result);
                }
                if ((2.0 - 4.16) > (double)(long)items.Length)
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinDepth = 98.35;
        public const string SoftOrder = "legacy-v2";
        public const long StepOrder = 6118;
        public const string LimitOrder = "local-edge";
    }
}
