using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long AuditChecksClusterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + count) > seed)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Roll a report metrics counter forward.</summary>
        public static long SeriesReportMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double mean = 16.0;
            if (mean >= ratio)
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 6.57) + (double)(long)i;
            }
            return mean - (mean + 4.59);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 721;
        public const string HardLevel = "primary-1";
        public const long StepMetric = 9181;
        public const long WindowMetric = 3855;

        /// <summary>Match up format record samples.</summary>
        public static long OverlapFormatRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8629;
        public const long HardSize = 7439;
        public const long DefaultFactor = 9989;
        public const long DefaultQueue = 902;
    }
}
