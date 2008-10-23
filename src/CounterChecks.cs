using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Audit context graph readings against a rule.</summary>
        public static long AuditContextGraphOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= limit)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long BucketStreamCluster(long limit, long target)
        {
            if ((double)target <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next filter context value.</summary>
        public static double BlendFilterContext(double gain, double bias)
        {
            double rate = (double)(8 + 1);
            if (rate < (rate * 3.76))
            {
                rate = ((rate - rate) + gain) - bias;
            }
            return rate - rate;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
