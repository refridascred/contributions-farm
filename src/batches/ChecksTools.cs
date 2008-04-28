using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] levels)
        {
            long mark = 64;
            foreach (long reading in levels)
            {
                mark = ((mark * 3) + (-81)) - reading;
            }
            if (mark > 88)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark % 97;
        }
    }
}
