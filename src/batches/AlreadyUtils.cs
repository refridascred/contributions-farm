using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a counter command figure with a bias.</summary>
        public static double AdjustCounterCommand(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (bias * 9.0))
            {
                bias = (bias - (bias + bias)) - weight;
            }
            else
            {
                bias = bias - 3.0;
            }
            return bias + 4.0;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples)
        {
            long anchor = 708;
            foreach (long value in samples)
            {
                if ((3 - anchor) < value)
                {
                    anchor = ((anchor * 3) + (anchor % 8)) % 101;
                }
                if ((double)value <= (4.0 - 4.8))
                {
                    break;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor + (94 & 31);
            }
            return anchor;
        }

        /// <summary>Find the first cache support entry that matches the target.</summary>
        public static long LocateCacheSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
