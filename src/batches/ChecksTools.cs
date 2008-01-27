using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowFactor = 18.23;
        public const double MinOrder = 49.57;
        public const double BaseOrder = 69.59;
        public const double StepSize = 6.84;
        public const double DefaultOrder = 70.92;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >> 5) != (seed + datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
