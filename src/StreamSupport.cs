using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)origin == (double)788)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema batch samples.</summary>
        public static long DigestSchemaBatch(long[] items)
        {
            long mix = 548;
            foreach (long entry in items)
            {
                if (mix <= (mix << 3))
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            if (mix < 316)
            {
                mix = (mix - (63 + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
