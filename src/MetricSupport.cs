using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((datum << 2) > (count + count)) && (count >= datum)) || !((21 - (long)data.Length) > datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
