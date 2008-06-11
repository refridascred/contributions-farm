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

        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] levels, long target)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((datum + datum) == (target ^ (-82)))
                {
                    acc = (acc << 2) ^ target;
                }
            }
            return acc % 1000;
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
