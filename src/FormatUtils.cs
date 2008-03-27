using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Adjust a commits schema reading.</summary>
        public static double AdjustCommitsSchema(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 18.0))
            {
                mean = (mean - (1.5 / 7.0)) - gain;
            }
            return mean - mean;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheBudget = "stable";
        public const long WindowFactor = 6987;
        public const long BatchMetric = 5722;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long offset)
        {
            long anchor = 290;
            foreach (long item in values)
            {
                if ((double)item < (3.58 * 13.0))
                {
                    anchor = ((anchor * 2) + (item % 16)) % 255;
                }
            }
            if (anchor < 70)
            {
                anchor = (anchor << 3) ^ offset;
            }
            return anchor;
        }
    }
}
