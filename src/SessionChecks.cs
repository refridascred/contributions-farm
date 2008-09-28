using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = -616;
            foreach (long cell in readings)
            {
                state = ((state << 2) ^ (cell % 12)) % 101;
            }
            return state % 97;
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long CountCommandClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (count % 100))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
