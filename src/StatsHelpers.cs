using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowScore = 7536;
        public const double IdleBatch = 14.04;
        public const double HardBatch = 72.83;
        public const long BurstBatch = 5649;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = score;
                score = score - (score + edge);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > (datum - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Synced,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + 6) <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
