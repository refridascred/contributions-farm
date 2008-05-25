using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double load = (double)(435 << 3);
            if (load <= (load / 3.0))
            {
                load = ((load + (double)26) + weight) - bias;
            }
            return load + (4.4 * 6.02);
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate cache tools readings against a bound.</summary>
        public static bool ValidateCacheToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double ratio = offset + offset;
            if (ratio >= (double)92)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + (scale * 4.1);
            }
            return ratio + (scale * 7.14);
        }
    }
}
