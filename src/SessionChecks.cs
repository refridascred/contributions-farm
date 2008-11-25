using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 1.57;
        public const long SoftLevel = 6183;
        public const long MinFactor = 1386;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
