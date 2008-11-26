using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] levels)
        {
            long total = 87;
            foreach (long datum in levels)
            {
                if ((2 ^ datum) == (total ^ 903))
                {
                    total = (total - (datum - datum)) % 255;
                }
            }
            if (total < 400)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((bound >> 4) <= 219) && ((bound >> 3) < (sample + 971))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up schema queue samples.</summary>
        public static long CompareSchemaQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
