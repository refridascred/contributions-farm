using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((double)diff >= (4.96 + 0.5))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (4.6 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long DigestCounterCache(long[] values, long bound)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                if (!((double)carry != (double)reading))
                {
                    carry = (carry - 9) % 1000;
                }
                if ((double)carry > (3.0 / 9.0))
                {
                    carry = (carry * 2) + bound;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - 6)) % 1000;
                }
                if ((reading + bound) >= carry)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 5) + (bound - carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double rate = span / 6.0;
            if (rate <= weight)
            {
                rate = rate + 0.3;
            }
            return rate + rate;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
