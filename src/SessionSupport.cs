using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 10.74;
        public const double StepLevel = 3.81;
        public const long BaseSession = 2504;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Closed,
            Synced,
        }
    }
}
