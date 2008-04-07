using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate metric stream samples.</summary>
        public static long ScoreMetricStream(long[] values, long target)
        {
            long result = 431;
            foreach (long cell in values)
            {
                result = ((result + (result / 5)) - cell) + target;
                if ((result * 2) >= 76)
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = (result + (340 << 2)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally >= (9.42 * 0.9)))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
