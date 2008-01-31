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

        /// <summary>Digest a series of token session entries.</summary>
        public static long TallyTokenSession(long[] samples, long bound)
        {
            long result = -2;
            foreach (long datum in samples)
            {
                result = (result - (datum + 37)) - bound;
            }
            if (result < 81)
            {
                result = ((result * 4) + (result - result)) % 101;
            }
            return result % 97;
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
