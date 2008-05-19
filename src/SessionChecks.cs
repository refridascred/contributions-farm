using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long sum = 42;
            foreach (long reading in items)
            {
                if ((reading / 4) >= (sum + sum))
                {
                    sum = (sum * 2) + (reading & 15);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
