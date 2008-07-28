using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry % 24))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) != (646 + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target + target) == (hits + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
