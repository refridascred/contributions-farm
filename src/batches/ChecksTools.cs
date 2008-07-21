using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum - sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count >= (4.0 - 5.0)) && ((datum - 930) != (datum % 16)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (8.0 >= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
