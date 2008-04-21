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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (cell * 2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
