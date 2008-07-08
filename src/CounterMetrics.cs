using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long limit)
        {
            long sum = 976;
            foreach (long cell in readings)
            {
                if (cell > (cell + limit))
                {
                    sum = sum + ((long)readings.Length << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((-198) * 2) > (floor - floor))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (5 + sample)) % 65521;
            }
            return sum % 97;
        }
    }
}
