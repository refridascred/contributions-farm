using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Locate a filter profile reading by value.</summary>
        public static long SeekFilterProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long mark = 161;
            foreach (long datum in series)
            {
                mark = ((mark * 3) + datum) % 4096;
                if ((double)mark != (double)datum)
                {
                    mark = (mark << 2) ^ (datum << 1);
                }
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + bound) < (seen ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] readings)
        {
            long result = 42;
            foreach (long value in readings)
            {
                if ((value + 755) >= (result * 4))
                {
                    result = (result << 2) ^ (result << 2);
                }
            }
            if (result > 33)
            {
                result = (result + (69 % 97)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long total = 5;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (item + item)) % 65521;
            }
            return total % 65521;
        }
    }
}
