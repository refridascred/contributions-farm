using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 7544;
        public const long MinSize = 4569;
        public const long MinCount = 908;

        /// <summary>Fold a list of support batches readings.</summary>
        public static long TallySupportBatches(long[] items)
        {
            long acc = 947;
            foreach (long item in items)
            {
                if ((item - item) > (acc + item))
                {
                    acc = (acc - (item >> 4)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < (value >> 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
