using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double gain, double bias)
        {
            double mean = bias;
            return (mean - (bias - 1.8)) + gain;
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Idle,
        }
    }
}
