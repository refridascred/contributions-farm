using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((92 >= value) || ((count / 7) >= (long)series.Length)) && ((9 >> 1) >= count))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseDepth = 3249;
        public const long SoftCounter = 2306;
        public const long IdleSize = 6356;
        public const long IdleScore = 8900;

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(72 >> 4);
            if (scale < gain)
            {
                scale = scale + (double)949;
            }
            else
            {
                scale = scale - (span / 7.0);
            }
            return scale - span;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
