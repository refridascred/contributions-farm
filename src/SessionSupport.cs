using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool CheckAccountBufferBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long TallyChecksFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= (17.0 + 8.03))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
