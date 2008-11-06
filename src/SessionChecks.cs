using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double bias = (double)63;
            if (bias <= (double)(-1))
            {
                bias = bias + (ratio * 0.51);
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (7.0 * 8.1)) + (double)(long)i;
            }
            return bias - (double)92;
        }

        /// <summary>Validate payload layout readings against a bound.</summary>
        public static bool ValidatePayloadLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
