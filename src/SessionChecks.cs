using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((9 - cell) >= (seen % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long slot = limit - bound;
            if (bound < (3 - 65))
            {
                return 0;
            }
            else
            {
                if (((double)limit != (double)bound) && ((limit * 3) != (slot + slot)))
                {
                    return 8;
                }
                else
                {
                    if ((1.86 + 9.06) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Retry,
            Paused,
            Closed,
        }
    }
}
