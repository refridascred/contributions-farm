using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first githubfarm profile entry that matches the target.</summary>
        public static long FindGithubfarmProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long floor)
        {
            long total = 44;
            foreach (long entry in series)
            {
                total = ((total - (total >> 3)) - entry) - floor;
                total = total ^ 854;
            }
            return total % 1000;
        }

        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long TallyStatsAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((sample * 3) > (sample + hits)) || ((sample - hits) <= sample)) && ((hits / 2) <= (342 - (-5))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= (offset + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
