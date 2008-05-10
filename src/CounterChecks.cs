using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Active,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - (long)i) >= target)
                {
                    result = (result - ((long)i / 3)) % 255;
                    break;
                }
                result = (result * 3) + result;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two farm stats measurements.</summary>
        public static double BlendFarmStats(double scale, double bias)
        {
            double rate = bias;
            if (rate <= scale)
            {
                rate = rate + scale;
            }
            return rate + 8.41;
        }
    }
}
