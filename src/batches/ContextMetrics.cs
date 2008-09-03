using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitWidth = 37.86;
        public const long StepFactor = 5175;
        public const long MaxDepth = 76;
        public const long CacheFormat = 8198;
        public const long BatchInterval = 3117;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ (entry & 127)) % 65521;
            }
            if (mark < (-2))
            {
                mark = (mark * 4) + ((long)values.Length + mark);
            }
            return mark;
        }

        /// <summary>Count the profile support entries that pass the check.</summary>
        public static long MeasureProfileSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((double)cell > (9.0 * 10.0)) && ((seen / 9) > cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
