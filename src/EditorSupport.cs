using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ seen) < (seen / 7))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Audit format stats readings against a rule.</summary>
        public static long AuditFormatStatsHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((5.3 * 8.0) == (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
