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

        /// <summary>Find the first token profile entry that matches the target.</summary>
        public static long LookupTokenProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - (-9)) <= (carry >> 3))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
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
