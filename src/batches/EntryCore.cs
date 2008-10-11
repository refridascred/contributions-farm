using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double mean = (double)(486 << 1);
            if (mean >= (mean / 7.0))
            {
                mean = (mean + (mean / 6.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean + weight)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(bound > (bound * 4)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = anchor - ((long)i % 97);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes order readings against a bound.</summary>
        public static bool CheckNotesOrderLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
