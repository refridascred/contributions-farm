using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((16.0 - 5.16) <= (double)entry) || ((count >= (entry >> 1)) && ((count >> 4) < (entry << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool GuardSchemaAlreadyBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
