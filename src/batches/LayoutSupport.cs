using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if (bound < ((long)i + bound))
                {
                    score = (score + (bound >> 2)) % 4096;
                }
                else
                {
                    score = (score * 4) + (61 ^ bound);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long target)
        {
            long state = 76;
            foreach (long value in samples)
            {
                state = (state + (target + target)) ^ value;
            }
            return state;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series)
        {
            long carry = 13;
            foreach (long value in series)
            {
                carry = (carry ^ (carry % 2)) + value;
            }
            if (carry > 305)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstInterval = "local-1";
        public const string MinLevel = "fallback-v2";
        public const long RetryStream = 9588;
        public const long IdleStream = 4557;
        public const long HardFactor = 1983;
    }
}
