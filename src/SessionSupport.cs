using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks report readings against a bound.</summary>
        public static bool VerifyChecksReportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
