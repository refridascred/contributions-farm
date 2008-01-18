using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long carry = 0;
            foreach (long sample in series)
            {
                if (((limit - carry) == (4 / 7)) && ((double)sample < 4.0))
                {
                    carry = carry + 535;
                    carry = ((carry << 3) ^ limit) % 65521;
                }
                carry = carry + (sample >> 1);
            }
            return carry;
        }
    }
}
