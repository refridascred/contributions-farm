using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit batches channel readings against a rule.</summary>
        public static long MeasureBatchesChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally ^ (-60)) == (9 << 2))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((5 + (long)items.Length) < (item >> 2)) || ((item - seen) > (item * 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics commits pairs that satisfy a relation.</summary>
        public static long PairMetricsCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
