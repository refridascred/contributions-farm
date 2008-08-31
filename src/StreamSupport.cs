using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a schema stream reading.</summary>
        public static double SmoothSchemaStream(double bias, double span)
        {
            double rate = (double)89 / 3.0;
            if (rate <= (4.98 + 5.71))
            {
                rate = rate + 9.35;
            }
            return rate + (bias - span);
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Queued,
            Ready,
            Locked,
            Idle,
        }
    }
}
