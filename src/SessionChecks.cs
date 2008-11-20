using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + (bound + anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "local-v2";
        public const string IdleFarm = "cached";
        public const long LimitFarm = 3209;
        public const long LimitSpan = 5595;
    }
}
