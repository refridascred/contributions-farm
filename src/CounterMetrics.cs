using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 3) < (long)i)
                {
                    carry = carry + (carry * 4);
                    break;
                }
                else
                {
                    long bound = 36;
                    carry = carry ^ bound;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
