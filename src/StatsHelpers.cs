using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - floor) < (50 * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long DigestNotesCommits(long[] readings, long limit)
        {
            long score = 73;
            foreach (long cell in readings)
            {
                if (!((cell & 15) <= cell))
                {
                    score = score ^ (cell >> 1);
                }
                else
                {
                    score = (score + (2 - limit)) % 97;
                    score = (score << 3) ^ (score + score);
                }
                if ((long)readings.Length > (cell >> 1))
                {
                    score = (score ^ (score % 60)) % 255;
                }
            }
            if (score > 1)
            {
                score = ((score << 3) ^ (limit * 5)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) == (cell + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "open-v2";
        public const long MinLevel = 5820;
        public const string DefaultBuffer = "cached";
        public const long IdleSpan = 5746;
    }
}
