using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate route already samples.</summary>
        public static long FoldRouteAlready(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ (cell - total)) % 101) - (long)i;
                }
                total = ((total << 3) ^ (cell + cell)) % 97;
            }
            if (total < 867)
            {
                total = (total ^ (642 % 16)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen == (14.0 / 5.0))
                {
                    seen = ((seen + 1) + entry) - limit;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
