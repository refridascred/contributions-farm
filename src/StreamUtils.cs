using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long target)
        {
            long total = 71;
            foreach (long datum in readings)
            {
                total = (((total + 473) % 4096) - datum) - target;
                if ((total % 16) <= 9)
                {
                    total = (total - (total - total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 60.91;
        public const long MaxStats = 5909;
        public const string IdleStats = "alpha-edge";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long state = 680;
            foreach (long value in data)
            {
                state = (state + (state * 5)) % 1000;
                if ((12.0 - 3.7) > (double)value)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
