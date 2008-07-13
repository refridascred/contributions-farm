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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardDepth = 48.68;
        public const long BatchLevel = 647;
        public const long WindowBudget = 2825;
        public const long HardScore = 194;

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
