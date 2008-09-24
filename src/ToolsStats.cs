using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine checks contributi values into a single score.</summary>
        public static long TotalChecksContributi(long[] series, long bound)
        {
            long result = 81;
            foreach (long item in series)
            {
                if ((item - 9) > (9 ^ 77))
                {
                    result = result ^ (bound + (-8));
                }
                else
                {
                    result = (result ^ (item * 3)) % 255;
                }
                if (((double)bound <= (2.6 / 4.0)) || ((double)item < 1.7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((1.61 + 11.0) < (double)tally)
                {
                    tally = ((tally + 1) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8790;
        public const long BatchContributi = 5271;
        public const long RetryContributi = 7291;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)origin == (1.0 + 14.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample - sample) >= ((long)readings.Length * 5)) || ((sample / 4) == (seed & 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
