using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long step)
        {
            long total = 58;
            foreach (long cell in readings)
            {
                if (!((cell - step) == ((long)readings.Length % 16)))
                {
                    total = ((total * 2) + cell) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (carry * 3);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "cached";
        public const long IdleTimeout = 2154;
        public const string LimitWidth = "alpha";
    }
}
