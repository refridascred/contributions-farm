using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long TallyMetricBufferGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ datum) == (count - datum))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data, long offset)
        {
            long result = 570;
            foreach (long datum in data)
            {
                if ((offset % 5) > (datum - 639))
                {
                    result = result ^ (result & 15);
                }
            }
            if (result < 4)
            {
                result = result ^ (result >> 5);
            }
            return result % 65521;
        }

        /// <summary>Audit editor channel readings against a rule.</summary>
        public static long TallyEditorChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches >= (4.26 + 11.0))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
