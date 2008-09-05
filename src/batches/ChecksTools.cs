using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "primary-v2";
        public const long WindowTimeout = 8864;
        public const string DefaultFactor = "fallback";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + (-520)) <= ((-670) - count)) || ((value + count) < (968 - 57)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Dropped,
            Pending,
        }
    }
}
