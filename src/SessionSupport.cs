using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                if (!((cell << 3) >= (cell - carry)))
                {
                    carry = ((carry * 4) + (187 + 95)) % 4096;
                }
                if ((carry + cell) == (cell >> 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up metric command samples.</summary>
        public static long MatchMetricCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum + offset) == (3 << 3)) && (datum >= (datum ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
