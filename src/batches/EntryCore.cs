using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of report commits readings.</summary>
        public static long DigestReportCommits(long[] items)
        {
            long total = 888;
            foreach (long entry in items)
            {
                total = (total - (total - 300)) - entry;
            }
            if (total < 338)
            {
                total = ((total * 2) + (224 * 3)) % 255;
            }
            return total;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 547;
            foreach (long reading in items)
            {
                result = result ^ (reading ^ reading);
                result = ((result << 3) ^ (reading - (-3))) % 97;
            }
            return result;
        }
    }
}
