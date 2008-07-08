using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series, long origin)
        {
            long mark = -921;
            foreach (long value in series)
            {
                mark = (((mark << 2) ^ (1 - origin)) % 1000) + value;
            }
            return mark % 4096;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if (!((double)entry != (16.0 - 2.2)))
                {
                    carry = (carry - (95 & 3)) % 101;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (711 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long CountChecksFormatOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches <= offset)
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
