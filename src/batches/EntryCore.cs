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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Queued,
            Active,
            Done,
        }
    }
}
