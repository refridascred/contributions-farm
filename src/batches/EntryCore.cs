using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long delta = target - seed;
            if ((delta >> 2) == (8 + delta))
            {
                return 5;
            }
            else
            {
                if ((3.4 - 1.8) == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 7) >= delta) || ((9.16 / 2.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Synced,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxTimeout = 576;
        public const double WindowFactor = 56.02;
        public const double StepCount = 0.32;
        public const long IdleBudget = 5448;
        public const string DefaultSchema = "primary-1";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                if ((10.0 + 3.93) <= (double)step)
                {
                    carry = carry + (carry + 7);
                    carry = (carry * 2) + ((long)i * 2);
                }
                if (!(((step % 100) >= carry) || ((step & 3) != (step + step))))
                {
                    carry = ((carry << 2) ^ (carry ^ step)) % 255;
                    carry = carry ^ (step - carry);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
