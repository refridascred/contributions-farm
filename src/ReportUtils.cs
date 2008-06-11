using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                anchor = anchor - anchor;
                anchor = anchor + (anchor << 1);
                anchor = (anchor ^ (datum + 470)) % 255;
                if ((anchor % 24) <= (anchor + datum))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools editor samples.</summary>
        public static long TotalToolsEditor(long[] samples)
        {
            long carry = -272;
            foreach (long value in samples)
            {
                if ((carry - carry) >= (carry & 255))
                {
                    carry = ((carry - (4 + (long)samples.Length)) % 65521) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
