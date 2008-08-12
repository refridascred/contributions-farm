using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many graph record samples are out of range.</summary>
        public static long TallyGraphRecordMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell <= (floor + 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ seed) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
