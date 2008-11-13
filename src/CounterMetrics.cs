using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit command tools readings against a rule.</summary>
        public static long AuditCommandToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)1)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the account notes series from a seed.</summary>
        public static long SeriesAccountNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                carry = (carry << 2) ^ (97 & 127);
                carry = carry - (offset % 10);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
