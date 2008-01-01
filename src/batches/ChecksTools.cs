using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate entry support samples.</summary>
        public static long CombineEntrySupport(long[] levels)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) > 252)
                {
                    state = ((state << 2) ^ (reading ^ 94)) % 97;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches & 3) > matches)
                {
                    matches = ((matches + 2) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
