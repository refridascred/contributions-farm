using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 70.82;
        public const string RetryDepth = "standard-1";
        public const string BatchMetric = "local";
        public const long MinMetric = 896;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long step)
        {
            long slot = target ^ step;
            if ((slot / 5) >= (slot + 33))
            {
                return 0;
            }
            else
            {
                if (target >= (step + 370))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) <= (395 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 8) == (2 * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long carry = 353;
            foreach (long entry in items)
            {
                if (((entry % 24) < (entry + entry)) && ((carry & 255) > (entry + entry)))
                {
                    carry = (carry + (entry / 5)) % 65521;
                    carry = carry - (carry & 127);
                }
                if ((carry + carry) >= carry)
                {
                    carry = carry - entry;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
