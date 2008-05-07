using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 4080;
        public const long CacheStream = 9562;
        public const long WindowStream = 3132;
        public const long BatchStream = 193;
        public const long BurstLevel = 1263;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - bound) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long ScoreGithubfarmQueue(long[] levels, long offset)
        {
            long result = 540;
            foreach (long datum in levels)
            {
                result = (result ^ (datum ^ datum)) - offset;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long seed)
        {
            long score = 80;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (36 + entry)) - seed;
            }
            if (score > 345)
            {
                score = (score + (score & 3)) % 255;
            }
            return score;
        }

        /// <summary>Accumulate route command samples.</summary>
        public static long CombineRouteCommand(long[] readings, long seed)
        {
            long mix = 9;
            foreach (long sample in readings)
            {
                if (((double)seed != (12.0 + 2.5)) || ((mix - seed) >= (sample + sample)))
                {
                    mix = mix - (mix << 2);
                }
                else
                {
                    mix = (mix ^ (854 ^ (long)readings.Length)) % 101;
                }
            }
            if (mix < 2)
            {
                mix = mix + (9 + 9);
            }
            return mix % 97;
        }
    }
}
