using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if (48 >= (bound - anchor))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor ^ (-310);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 365;
            foreach (long value in values)
            {
                if ((state / 5) <= (value ^ (-33)))
                {
                    state = ((state << 3) ^ (value + (-1))) % 101;
                }
                else
                {
                    state = ((state * 2) + (state + value)) % 101;
                }
            }
            return state;
        }
    }
}
