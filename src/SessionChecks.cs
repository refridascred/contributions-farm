using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Queued,
            New,
            Idle,
            Done,
        }

        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value & 63) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = 7.03;
            if (weight > 0.1)
            {
                weight = (weight - (weight - weight)) - ratio;
            }
            else
            {
                weight = weight - (bias - 0.1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (double)14) - (double)(long)i;
            }
            return weight + (double)612;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Stale,
            Pending,
            Idle,
            Draft,
        }
    }
}
