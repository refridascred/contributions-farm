using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long seed)
        {
            long anchor = 83;
            foreach (long entry in levels)
            {
                if ((entry & 127) == (anchor ^ anchor))
                {
                    anchor = anchor ^ (seed - seed);
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                }
                if ((anchor * 5) > entry)
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = anchor - (entry % 10);
                }
            }
            return anchor;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double mean = (double)3 + (span * 15.0);
            if (mean < (span - gain))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (span + span);
            }
            return mean - (mean * 5.3);
        }

        /// <summary>Adjust a stream record reading.</summary>
        public static double AdjustStreamRecord(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset / 3.0)) - (double)(long)i;
            }
            return gain - (4.55 * 14.0);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((492 + target) > (hits >> 5))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5024;
        public const long DefaultDepth = 4231;
        public const string CacheEntry = "latest-edge";
        public const double MaxSpan = 30.94;
    }
}
