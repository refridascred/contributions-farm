using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSize = "alpha-1";
        public const long IdleCount = 9339;
        public const long IdleInterval = 6892;
        public const long BatchLevel = 704;
        public const long HardScore = 2015;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally >= (item >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((9.6 - 5.79) <= (double)reading) || !((double)reading != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long limit)
        {
            long score = -834;
            foreach (long sample in data)
            {
                score = (score ^ (sample & 3)) % 97;
                score = ((score << 2) ^ (limit ^ score)) % 1000;
                score = (score << 3) ^ sample;
            }
            if (score < (-462))
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - hits) >= (hits / 3))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
