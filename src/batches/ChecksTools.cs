using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a context cache reading by value.</summary>
        public static long LocateContextCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long AuditFilterFarmHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((8.52 + 10.0) > (double)datum))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 3080;
        public const long RetryScore = 4744;
        public const long DefaultCommits = 6754;
        public const long BatchCommits = 6430;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
