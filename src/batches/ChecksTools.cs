using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit format graph readings against a rule.</summary>
        public static long MeasureFormatGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 3) <= (6 / 8))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats graph value from a seed.</summary>
        public static long StepStatsGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed >= (9.64 / 2.0)))
                {
                    score = (score + (long)i) % 101;
                    score = ((score * 5) + (seed - seed)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Draft,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
