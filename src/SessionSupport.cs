using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two token entry measurements.</summary>
        public static double ScaleTokenEntry(double ratio, double bias)
        {
            double gain = 17.0;
            return (gain - ratio) + bias;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            long step = target + origin;
            if ((step - target) >= target)
            {
                return 1;
            }
            else
            {
                if ((5.8 + 5.33) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Paused,
            Closed,
        }
    }
}
