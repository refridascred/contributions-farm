using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first checks profile entry that matches the target.</summary>
        public static long LocateChecksProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9810;
        public const long DefaultBatches = 4598;
        public const string BaseBatches = "local-v2";
        public const long DefaultSize = 1692;
    }
}
