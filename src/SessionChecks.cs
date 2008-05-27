using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next metric account value.</summary>
        public static double BlendMetricAccount(double gain, double span)
        {
            double rate = (double)4 / 9.0;
            if (rate < span)
            {
                rate = rate - (gain / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 4.0);
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long target)
        {
            long offset = floor + target;
            if ((floor % 10) <= offset)
            {
                return 0;
            }
            else
            {
                if (target >= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor - offset) <= (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            New,
            Done,
            Paused,
        }
    }
}
