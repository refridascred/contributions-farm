using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < value)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4030;
        public const double WindowTimeout = 36.87;
        public const long BatchScore = 3317;
        public const long IdleWidth = 6425;
        public const long LimitFactor = 9099;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double rate2 = (double)(41 + 5);
            if (rate2 <= (floor - rate))
            {
                rate2 = rate2 - floor;
            }
            return rate2 + rate2;
        }
    }
}
