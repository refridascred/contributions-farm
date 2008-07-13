using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up commits command samples.</summary>
        public static long MatchCommitsCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)target <= 1.0)
                {
                    total = (total ^ (target + 50)) % 65521;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.02 / 9.0) < (double)seed)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long acc = 688;
            foreach (long reading in levels)
            {
                acc = (acc << 2) ^ (acc - 6);
                acc = ((acc << 2) ^ reading) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long result = 48;
            foreach (long reading in series)
            {
                if (!((reading & 31) != (reading + result)))
                {
                    result = (((result * 3) + (result * 3)) % 101) - offset;
                }
                else
                {
                    result = result + (result + result);
                }
            }
            return result;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
