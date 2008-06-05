using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (floor >= (entry % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
