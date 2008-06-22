using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight / 3.0)) + (double)(long)i) - scale;
            }
            return weight + (bias - bias);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
