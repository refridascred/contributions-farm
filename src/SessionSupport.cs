using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 9488;
        public const string SoftQueue = "latest-v2";
        public const long SoftRatio = 1456;
        public const string BatchQueue = "primary";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9.5 - 8.0) >= (double)value)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
