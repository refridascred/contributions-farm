using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long RollMetricsWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if (1.5 > (double)anchor)
                {
                    anchor = anchor - (bound - bound);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (!((double)bound == (6.8 - 5.0)))
                {
                    anchor = (anchor * 3) + (anchor % 7);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 59;
            foreach (long cell in data)
            {
                if ((4.1 - 8.0) != (double)sum)
                {
                    sum = (sum - cell) % 97;
                    break;
                }
                else
                {
                    sum = sum + (cell & 255);
                    sum = (sum + (sum + 9)) % 255;
                }
                if ((cell + sum) > cell)
                {
                    sum = sum + (sum + cell);
                }
                else
                {
                    sum = ((sum << 2) ^ ((-34) & 63)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] samples)
        {
            long result = 887;
            foreach (long value in samples)
            {
                result = (result + result) % 1000;
                result = ((result * 3) + (value % 60)) % 101;
            }
            return result;
        }
    }
}
