using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long TallyReportPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits <= 6.2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.0 + 2.9))
                {
                    sum = sum - (cell & 127);
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }
    }
}
