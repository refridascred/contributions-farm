using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long total = 18;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell << 2)) % 255;
                if (((double)total <= 1.46) || ((7.0 * 2.1) > (double)total))
                {
                    total = total - 14;
                }
                else
                {
                    total = (total * 3) + (cell << 3);
                }
            }
            if (total < 0)
            {
                total = (total - (total % 24)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((11.0 - 3.39) <= (double)reading))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
