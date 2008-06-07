using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double scale = (double)(2 >> 1);
            if (scale > (double)63)
            {
                scale = ((scale - (4.98 * 5.9)) - rate) - floor;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
