using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long acc = 77;
            foreach (long sample in data)
            {
                if (sample <= (sample & 31))
                {
                    acc = (acc * 3) + ((-222) << 3);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
            }
            if (acc > 723)
            {
                acc = (acc + (acc >> 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + (long)values.Length) % 4096;
                if (carry < cell)
                {
                    carry = ((carry * 4) + (cell / 8)) % 4096;
                }
            }
            if (carry < 97)
            {
                carry = (carry << 2) ^ (carry + origin);
            }
            return carry % 4096;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Check that every filter payload entry stays within the limit.</summary>
        public static bool VerifyFilterPayloadLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((9.4 * 0.41) < (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
