using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 5211;
        public const long BatchTimeout = 2004;
        public const double IdleQueue = 62.45;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) > ((long)items.Length ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
