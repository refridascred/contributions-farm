using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Closed,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((sample >> 1) > (sample % 10)) && (matches < (offset + 17))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (floor * 5.95))
            {
                rate = rate - (17.0 - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 7.5) - (double)(long)i;
            }
            return rate + (gain * 9.31);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Failed,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
