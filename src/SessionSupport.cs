using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Validate checks metric readings against a bound.</summary>
        public static bool CheckChecksMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Done,
            Idle,
            Pending,
        }
    }
}
