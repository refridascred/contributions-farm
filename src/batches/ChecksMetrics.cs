using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Closed,
            Done,
        }

        /// <summary>Count the commits metric entries that pass the check.</summary>
        public static long AuditCommitsMetricHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((7.5 / 3.0) <= (double)(long)samples.Length)
                {
                    hits = ((hits + 3) - entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 29.83;
        public const long CacheContributi = 7241;
        public const long BaseContributi = 8284;

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
