using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((9.3 * 6.0) < (double)tally)
                {
                    tally = ((tally + 2) + datum) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long FindContributiOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long SeriesTokenGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((8.8 * 0.1) >= (double)floor)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total + floor) % 65521;
                    total = (total - (floor - floor)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (mix - origin) + sample;
            }
            return mix % 1000;
        }
    }
}
