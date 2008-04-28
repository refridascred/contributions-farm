using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long ClassifyStreamEditor(long origin, long target)
        {
            long cur = origin - target;
            if (((double)origin <= (double)target) && ((double)target > (8.25 + 6.5)))
            {
                return 5;
            }
            else
            {
                if (cur < (4 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur == (18.0 - 5.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Scale a session contributi figure with a bias.</summary>
        public static double ProjectSessionContributi(double rate, double bias)
        {
            double rate2 = (rate * 6.15) / 8.0;
            if (rate2 < (bias + bias))
            {
                rate2 = rate2 + (bias + rate2);
            }
            return rate2 + bias;
        }
    }
}
