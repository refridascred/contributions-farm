using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format context readings.</summary>
        public static long FoldFormatContext(long[] items)
        {
            long total = 17;
            foreach (long datum in items)
            {
                if (!(datum > (985 - total)))
                {
                    total = (total * 3) + (total - total);
                }
                if ((6 >> 4) <= (datum + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
