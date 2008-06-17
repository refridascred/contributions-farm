using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long AuditRouteOrderOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits <= (36 + cell))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values, long step)
        {
            long carry = 62;
            foreach (long value in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = carry - (value - value);
                    carry = (carry ^ ((long)i & 3)) % 101;
                }
                if (((carry << 1) != (value + 936)) && ((carry - step) == (carry + step)))
                {
                    carry = carry ^ (-46);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 4943;
        public const long HardSupport = 5419;
        public const string SoftSupport = "fallback";
        public const long BurstSupport = 6070;
        public const long MaxSupport = 4726;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (sum ^ sum)) % 4096;
                if (!(((long)i * 2) <= ((long)i - sum)))
                {
                    sum = (sum + (bound & 1)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
