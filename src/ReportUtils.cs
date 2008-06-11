using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
