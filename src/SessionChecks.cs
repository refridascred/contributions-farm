using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if ((3.23 + 0.96) <= (double)step)
                {
                    state = (state ^ (state - state)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
