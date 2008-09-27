using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry format sample.</summary>
        public static long SeekEntryFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double bias2 = (double)(263 & 1);
            return ((bias2 - (double)72) + weight) + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) == (datum * 4))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((2.17 + 6.0) <= (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 3366;
        public const double SoftLevel = 7.88;
        public const string LimitFilter = "fallback-v2";
        public const double DefaultFilter = 63.66;
    }
}
