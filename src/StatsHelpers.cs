using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4 >> 1) < (9 - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long target)
        {
            long total = 137;
            foreach (long reading in readings)
            {
                if ((3.94 * 8.1) != (double)reading)
                {
                    total = (total - (total - reading)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = total ^ ((-27) << 1);
                if (total >= (8 % 97))
                {
                    total = (total + target) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
