using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support command samples.</summary>
        public static long PairSupportCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long ScoreSchemaStream(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ 21) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit - limit) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
