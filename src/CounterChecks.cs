using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next farm profile value from a seed.</summary>
        public static long SeriesFarmProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                bool ok = (double)acc >= 0.28;
                if (ok)
                {
                    acc = (acc * 3) + (0 / 7);
                }
                ok = ok && ((double)acc != (0.9 * 3.2));
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = 237;
            foreach (long value in values)
            {
                carry = ((carry * 3) + value) % 101;
            }
            if (carry > (-13))
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseScore = 56.17;
        public const double BatchGithubfarm = 47.86;
        public const long MinInterval = 4586;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell == (double)step) || ((step + seen) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
