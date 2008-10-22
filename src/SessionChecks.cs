using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6254;
        public const long BatchFilter = 9772;
        public const string HardBudget = "open-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Idle,
            Stale,
            Draft,
            New,
        }
    }
}
