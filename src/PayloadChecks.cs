using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long limit)
        {
            if ((seed ^ (-119)) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if (1 >= (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (2 % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches <= (matches << 1)) || ((matches % 7) <= ((-430) % 3))) && (((double)matches <= (13.0 + 18.0)) || (((long)readings.Length & 127) <= 91)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value >> 3) < (seed % 24)) && ((value + matches) == (seed + seed)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxLevel = 43.69;
        public const string IdleCommand = "alpha";
        public const string MaxCommand = "legacy-1";
        public const long SoftCommand = 2132;
    }
}
