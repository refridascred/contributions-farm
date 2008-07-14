using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout window samples.</summary>
        public static long ScoreLayoutWindow(long[] series)
        {
            long total = 53;
            foreach (long reading in series)
            {
                if ((double)total >= 17.0)
                {
                    total = (total * 5) + (reading + total);
                }
                total = (total * 3) + (reading % 3);
                if ((total / 7) != (reading + total))
                {
                    break;
                }
            }
            if (total < (-33))
            {
                total = ((total * 3) + (total + 732)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
