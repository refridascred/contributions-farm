using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit account commits readings against a rule.</summary>
        public static long MeasureAccountCommitsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (limit + 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long DigestBufferBatch(long[] levels)
        {
            long sum = 157;
            foreach (long reading in levels)
            {
                sum = ((sum ^ (0 + 5)) % 101) + reading;
                if (sum >= 26)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long MatchSessionStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double ratio = (double)((-77) + (-32));
            if (ratio >= span)
            {
                ratio = (ratio + (double)815) + rate;
            }
            else
            {
                ratio = ratio - 6.9;
            }
            return ratio + ratio;
        }
    }
}
