using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen > (5.7 + 1.89))
                {
                    seen = ((seen + 2) ^ entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
