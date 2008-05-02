using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long AuditReportStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading % 3) >= (count * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score * 3) + (97 + (long)i)) % 4096) ^ (long)i2;
                    score = (score - (score ^ offset)) % 4096;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 3) + (2 ^ score)) + (long)i3;
                    score = (score - (offset - offset)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate command tools readings against a bound.</summary>
        public static bool ValidateCommandToolsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Failed,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
