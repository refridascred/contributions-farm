using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3382;
        public const long BaseContext = 3758;
        public const string DefaultContext = "strict";

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long carry = 749;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = (carry ^ (8 % 100)) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry - entry);
                }
            }
            if (carry > (-644))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (step <= (step ^ 449))
                {
                    mix = mix + step;
                }
                if ((double)cell > (11.0 - 4.45))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Idle,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 6082;
        public const long MinCluster = 2603;
        public const long HardCluster = 383;
    }
}
