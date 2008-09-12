using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of stats payload readings.</summary>
        public static long OverlapStatsPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long mix = 35;
            foreach (long item in levels)
            {
                if (((double)item >= (1.3 - 6.0)) || ((item - mix) <= (item + mix)))
                {
                    mix = (mix << 3) ^ bound;
                }
                else
                {
                    mix = (mix - (6 >> 1)) % 97;
                }
            }
            if (mix < 1)
            {
                mix = ((mix * 4) + (bound ^ 33)) % 97;
            }
            return mix;
        }
    }
}
