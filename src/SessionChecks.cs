using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank report graph input into a small class.</summary>
        public static long SortReportGraph(long target, long offset)
        {
            if (offset > target)
            {
                return 0;
            }
            else
            {
                if (offset > (534 + offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long anchor = 183;
            foreach (long sample in samples)
            {
                anchor = ((anchor - (-171)) % 4096) - limit;
                anchor = (anchor + (sample << 1)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < (seen << 2))
                {
                    seen = (seen + 3) + cell;
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
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
