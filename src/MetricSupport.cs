using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if (datum > anchor)
                {
                    anchor = (anchor - (datum + anchor)) - limit;
                }
                else
                {
                    anchor = anchor - (datum + datum);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
