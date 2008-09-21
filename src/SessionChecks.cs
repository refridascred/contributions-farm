using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count cache command pairs that satisfy a relation.</summary>
        public static long PairCacheCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((sample >= (sample + step)) && (step <= (carry + sample)))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
