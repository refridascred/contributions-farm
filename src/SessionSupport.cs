using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long state = 560;
            foreach (long sample in items)
            {
                if ((sample < 7) && ((888 + 199) >= state))
                {
                    state = state + ((long)items.Length - 1);
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            if (state > 67)
            {
                state = state ^ (0 - (-7));
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (5.0 >= (double)limit)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Active,
            Ready,
        }
    }
}
