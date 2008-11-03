using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = (mix ^ sample) % 97;
            }
            if (mix > 9)
            {
                mix = (mix + ((long)data.Length - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a stats metrics reading by value.</summary>
        public static long LookupStatsMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-v2";
        public const double MaxQueue = 46.84;
        public const long SoftQueue = 91;
    }
}
