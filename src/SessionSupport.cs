using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double weight = 5.23;
            if (weight < (weight + span))
            {
                weight = weight + (weight - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span * 7.55)) + (double)(long)i;
            }
            return weight + (double)9;
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long AuditContextMetricOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (origin > seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
