using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            New,
            Draft,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((double)count < (6.59 + 0.2)) && ((count ^ count) != (item - 27))) || ((count - 3) != (item & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
