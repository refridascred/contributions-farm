using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long SortCommandRecord(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (((origin >> 5) <= (origin << 1)) || ((lane + origin2) > (origin >> 1)))
            {
                return 5;
            }
            else
            {
                if ((origin + lane) >= (lane + 59))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 2436;
        public const long BaseBatches = 2111;
        public const string MaxBatches = "fallback";
        public const string CacheLevel = "strict-v2";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the farm stream entries that pass the check.</summary>
        public static long TallyFarmStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 1) != (tally ^ cell)) || ((cell / 9) != ((-807) * 4)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
