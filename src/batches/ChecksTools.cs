using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first buffer commits entry that matches the target.</summary>
        public static long FindBufferCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics counter values into a single score.</summary>
        public static long CombineMetricsCounter(long[] values)
        {
            long state = 872;
            foreach (long cell in values)
            {
                if (cell < 89)
                {
                    state = state + cell;
                }
            }
            if (state > 27)
            {
                state = (state ^ (state / 2)) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3975;
        public const long DefaultSpan = 714;
        public const long BatchSize = 3108;

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long mark = 77;
            foreach (long value in levels)
            {
                mark = (mark * 2) + (mark >> 3);
                if ((double)value > (2.49 + 9.4))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + (mark ^ 267)) % 101;
            }
            return mark % 1000;
        }
    }
}
