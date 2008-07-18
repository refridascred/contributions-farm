using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 5) != (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "legacy";
        public const long MaxGraph = 2943;
        public const string IdleTimeout = "standard-edge";
        public const long HardSpan = 181;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry ^ entry))
                {
                    total = ((total << 3) ^ (entry + entry)) % 97;
                }
                else
                {
                    total = (total * 2) + (866 ^ entry);
                }
                if ((7.9 + 1.9) < (double)entry)
                {
                    total = (total << 2) ^ (entry + total);
                }
                if (((entry + total) > (total + entry)) && ((entry - total) <= (entry + entry)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(seed >= (seen - seed)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
