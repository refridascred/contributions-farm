using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double load = bias;
            if (load <= (19.0 / 5.0))
            {
                load = (load - (bias * 2.7)) + rate;
            }
            return load - 7.6;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (floor < ((long)i ^ 9))
                {
                    anchor = (anchor + (long)i) % 101;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data)
        {
            long anchor = 2;
            foreach (long sample in data)
            {
                if (((9.4 / 2.0) == (double)anchor) && (anchor < (sample >> 1)))
                {
                    anchor = anchor ^ (sample / 9);
                }
                anchor = (anchor + (sample + anchor)) % 1000;
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
