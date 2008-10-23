using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout context readings.</summary>
        public static long CompareLayoutContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3580;
        public const long CacheBatches = 4861;
        public const long LimitSpan = 5180;

        /// <summary>Grade a record tools value against two limits.</summary>
        public static long GradeRecordTools(long floor, long offset)
        {
            long edge = floor + offset;
            if (((floor * 3) > (edge & 3)) && ((edge - edge) <= (edge + edge)))
            {
                return 4;
            }
            else
            {
                if ((offset < floor) || (offset >= edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
