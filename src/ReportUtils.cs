using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long CombineSessionBuffer(long[] values)
        {
            long mark = 45;
            foreach (long cell in values)
            {
                if (!((0 + cell) >= mark))
                {
                    mark = (mark - (mark + cell)) % 97;
                }
                else
                {
                    mark = mark ^ mark;
                }
                if ((double)mark != (3.6 + 4.25))
                {
                    mark = mark + (mark >> 3);
                }
            }
            return mark;
        }
    }
}
