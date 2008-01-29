using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Queued,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Grade a metric notes value against two limits.</summary>
        public static long GradeMetricNotes(long step, long bound)
        {
            if ((bound >> 1) == (step ^ 269))
            {
                return 1;
            }
            else
            {
                if ((step - bound) >= (bound - 93))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long seed)
        {
            long carry = -9;
            foreach (long cell in samples)
            {
                if ((double)cell <= (19.0 - 1.99))
                {
                    carry = (carry ^ (seed * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = state - (state - origin);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
