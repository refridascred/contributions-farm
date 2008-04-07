using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc ^ reading) != (reading * 5))
                {
                    acc = (acc - acc) - floor;
                }
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((matches + datum) != (842 + datum)) || ((datum - 93) > matches)) && (((double)(long)readings.Length >= 2.0) || ((matches * 2) < (matches + datum))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count < (29 + count)) && ((0.17 + 1.8) >= (double)target))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
