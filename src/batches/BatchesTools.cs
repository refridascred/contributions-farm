using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 55.06;
        public const long WindowChecks = 8058;
        public const long StepChecks = 5988;
        public const string IdleDepth = "cached-1";
        public const string SoftChecks = "latest-1";

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long carry = 97;
            foreach (long reading in values)
            {
                if (reading > ((-18) & 63))
                {
                    carry = carry + (reading + reading);
                    carry = (carry ^ (reading + 25)) % 255;
                }
                carry = ((carry << 3) ^ (carry << 2)) % 97;
                if (!((reading - reading) == (reading * 5)))
                {
                    carry = (carry ^ reading) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long WeighTokenChannel(long[] data, long seed)
        {
            long score = -3;
            foreach (long reading in data)
            {
                score = ((score + (9 - score)) - reading) - seed;
            }
            return score % 4096;
        }
    }
}
