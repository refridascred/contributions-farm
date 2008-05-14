using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit << 2) != (cell - 9))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
