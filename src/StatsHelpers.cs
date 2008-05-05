using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double mean = (double)(327 * 4);
            if (mean >= rate)
            {
                mean = (mean - mean) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + 2.0;
        }

        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long MeasureSupportEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally + tally) != (90 + tally)) && ((cell >> 4) < (tally ^ cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 1714;
        public const double SoftSize = 38.4;
        public const string BatchToken = "cached";
        public const long MinToken = 1711;
        public const long IdleToken = 5966;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((carry >> 1) > 36)
                {
                    carry = ((carry * 2) + (carry - 20)) % 4096;
                }
                carry = carry ^ (carry + origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
