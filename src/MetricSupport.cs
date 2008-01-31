using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up metric checks samples.</summary>
        public static long CompareMetricChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
