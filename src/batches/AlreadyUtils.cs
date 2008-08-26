using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached";
        public const long BurstLevel = 4927;
        public const long IdleCommits = 3695;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally <= (entry << 1)) && ((18.0 / 9.0) == (double)target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen > (17.0 - 3.3)) && ((value + seen) > value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }
    }
}
