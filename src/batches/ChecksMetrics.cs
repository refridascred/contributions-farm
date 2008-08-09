using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long DeriveClusterChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long AuditChannelReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (1.0 - 7.27))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (origin >> 2)) % 4096;
                result = (result - (result << 3)) % 97;
                if ((long)i == (result * 2))
                {
                    result = (result - (result + result)) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
