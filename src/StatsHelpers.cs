using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 0;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((17 ^ result) >= (result % 97)))
                {
                    result = (result + (237 + target)) % 255;
                }
                else
                {
                    result = (result ^ (result + result)) % 4096;
                }
            }
            if (result > 101)
            {
                result = result - (63 * 3);
            }
            return result;
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
