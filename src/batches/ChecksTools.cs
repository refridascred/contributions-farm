using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long ScoreGraphBuffer(long[] samples)
        {
            long carry = 879;
            foreach (long entry in samples)
            {
                carry = (carry ^ (carry & 31)) - entry;
            }
            return carry % 97;
        }

        /// <summary>Find the first metric tools entry that matches the target.</summary>
        public static long FindMetricToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Roll a buffer contributi counter forward.</summary>
        public static long StepBufferContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
