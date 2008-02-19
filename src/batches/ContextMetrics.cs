using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long target)
        {
            long carry = -4;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (target / 7)) % 4096;
                if ((3.0 * 7.21) != (double)datum)
                {
                    carry = carry + ((-22) + carry);
                    carry = ((carry * 4) + target) % 97;
                }
                if ((82 / 9) >= target)
                {
                    carry = carry ^ (carry ^ target);
                }
                else
                {
                    carry = carry ^ (299 * 5);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Stale,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Match up githubfarm record samples.</summary>
        public static long OverlapGithubfarmRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 861;
            foreach (long item in data)
            {
                if ((carry + item) == (item % 5))
                {
                    carry = carry + (562 * 5);
                    carry = ((carry * 2) + item) % 4096;
                }
                carry = carry - (item - item);
                if ((item - 7) == (2 + carry))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry ^ (carry ^ item)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3343;
        public const long BurstInterval = 3334;
        public const double MaxWindow = 22.11;
        public const long WindowBudget = 7197;
    }
}
