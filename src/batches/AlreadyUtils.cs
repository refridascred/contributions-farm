using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((4 % 12) == (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema contributi readings.</summary>
        public static long MatchSchemaContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Audit contributi notes readings against a rule.</summary>
        public static long MeasureContributiNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length <= (hits + value)) && ((double)value > (3.3 * 7.0))) && ((value << 1) < (hits / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
