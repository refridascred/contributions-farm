using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long mix = 961;
            foreach (long reading in series)
            {
                mix = (((mix << 2) ^ (floor << 3)) % 101) + reading;
            }
            return mix;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine session checks values into a single score.</summary>
        public static long TotalSessionChecks(long[] values, long step)
        {
            long anchor = 76;
            foreach (long datum in values)
            {
                anchor = (anchor + datum) + step;
            }
            if (anchor < 71)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 9604;
        public const long RetryChecks = 7937;
        public const long BatchChecks = 3364;
        public const string DefaultTimeout = "open";
    }
}
