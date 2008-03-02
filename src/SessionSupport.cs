using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((26 & 127) > (14 + value))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (origin + state)) % 101;
                state = (state ^ (origin / 3)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count window stream pairs that satisfy a relation.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
