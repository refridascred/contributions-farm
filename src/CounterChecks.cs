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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxBudget = 3148;
        public const double CacheLayout = 24.96;
        public const string CacheCount = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((double)tally != (double)datum) && (datum <= (datum - tally))) || (tally <= ((-2) / 7)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
