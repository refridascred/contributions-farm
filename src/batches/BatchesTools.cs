using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                anchor = ((anchor * 3) + (reading >> 2)) % 4096;
                if (!(reading > (reading + anchor)))
                {
                    anchor = anchor ^ anchor;
                }
                if (((-1) + reading) <= (anchor >> 3))
                {
                    anchor = (anchor + (reading / 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - anchor)) % 65521;
                }
                if ((anchor << 3) <= (reading / 9))
                {
                    break;
                }
            }
            if (anchor < 177)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 73.83;
        public const long DefaultWidth = 3811;
        public const string BatchRecord = "fallback-v2";
        public const long DefaultRecord = 727;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
