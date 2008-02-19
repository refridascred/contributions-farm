using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((count << 1) != (count - offset)) && (1 < reading)) && (offset < reading))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long floor)
        {
            if ((0.5 * 9.78) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor % 24) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 88.99;
        public const long DefaultSize = 2855;
        public const string BaseContributi = "standard-v2";
    }
}
