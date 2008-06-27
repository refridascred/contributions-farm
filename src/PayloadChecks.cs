using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry <= 57))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)8 <= (double)count)
                {
                    count = ((count + 3) ^ item) - limit;
                }
            }
            return count;
        }
    }
}
