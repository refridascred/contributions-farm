using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const string MaxTimeout = "fallback-edge";
        public const double HardWidth = 26.36;
        public const long WindowSize = 5646;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long AuditSessionWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((3 & 7) >= entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 4.71;
        public const double HardLevel = 90.94;
        public const long MinDepth = 6425;
    }
}
