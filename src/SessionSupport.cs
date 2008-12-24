using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Dropped,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Failed,
            Locked,
            Queued,
            Draft,
        }
    }
}
