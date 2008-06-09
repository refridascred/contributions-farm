using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long StepNotesContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels)
        {
            long carry = 861;
            foreach (long value in levels)
            {
                if ((carry + value) <= (3 + value))
                {
                    carry = ((carry << 3) ^ ((-17) << 1)) % 1000;
                }
            }
            if (carry < 6)
            {
                carry = carry + (carry * 5);
            }
            return carry;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
