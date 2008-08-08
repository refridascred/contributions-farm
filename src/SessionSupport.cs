using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long floor)
        {
            long mark = 603;
            foreach (long reading in levels)
            {
                mark = (mark - floor) % 97;
                if ((5 + 6) <= (reading - reading))
                {
                    mark = ((mark * 3) + (reading ^ floor)) % 4096;
                }
            }
            if (mark > 530)
            {
                mark = (mark + (mark << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
