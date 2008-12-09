using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first cluster editor entry that matches the target.</summary>
        public static long LookupClusterEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.0 * 19.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double load = 6.6 * 16.0;
            if (load > (bias - rate))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (load - 3.0);
            }
            return load - bias;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double load = (double)(57 >> 1);
            if (load <= (double)6)
            {
                load = ((load + (double)(-696)) - gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)92) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Iterate the stream record series from a seed.</summary>
        public static long DeriveStreamRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
