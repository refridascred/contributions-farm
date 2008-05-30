using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long seed)
        {
            long bound = limit + seed;
            if (seed >= (seed / 8))
            {
                return 1;
            }
            else
            {
                if ((bound + 8) < (seed << 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long limit)
        {
            long anchor = 22;
            foreach (long item in readings)
            {
                if (((long)readings.Length ^ anchor) < limit)
                {
                    anchor = (anchor << 3) ^ (limit + 71);
                }
                anchor = ((anchor * 2) + item) % 1000;
                anchor = ((anchor * 3) + (item * 3)) % 101;
            }
            return anchor;
        }
    }
}
