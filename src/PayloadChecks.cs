using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) > 11)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch account value from a seed.</summary>
        public static long SeriesBatchAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((limit * 5) >= (limit % 16)))
                {
                    score = ((score * 5) + (limit & 31)) % 4096;
                }
                score = (score << 3) ^ (limit ^ score);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long sum = 30;
            foreach (long item in data)
            {
                if (!((double)offset > (8.4 - 7.39)))
                {
                    sum = ((sum * 2) + (sum ^ (-90))) ^ item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
