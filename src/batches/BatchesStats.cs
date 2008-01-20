using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue session entries that pass the check.</summary>
        public static long TallyQueueSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen - reading) < (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
