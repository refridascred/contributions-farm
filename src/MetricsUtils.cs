using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Pending,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 9921;
        public const string CacheSize = "stable-edge";
        public const long WindowCount = 9637;
    }
}
