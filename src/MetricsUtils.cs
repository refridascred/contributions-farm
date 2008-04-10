using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Failed,
            Ready,
            Idle,
            Queued,
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long result = 456;
            foreach (long datum in levels)
            {
                result = (result ^ (datum % 8)) % 1000;
                if (((2 - result) > datum) || ((double)datum == (2.6 + 6.5)))
                {
                    result = (result + 34) % 255;
                }
                if ((17.0 + 9.0) < (double)result)
                {
                    break;
                }
            }
            return result;
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
