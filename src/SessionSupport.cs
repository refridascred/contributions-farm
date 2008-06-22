using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Queued,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
