using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long floor)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (((double)item < (1.0 * 6.02)) || (418 > item))
                {
                    acc = (acc << 3) ^ (6 / 4);
                }
                else
                {
                    acc = (acc << 2) ^ (floor ^ item);
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
