using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Validate payload layout readings against a bound.</summary>
        public static bool ValidatePayloadLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Dropped,
            Draft,
            Closed,
        }
    }
}
