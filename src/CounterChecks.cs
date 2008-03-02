using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((double)matches != (8.7 * 17.0)) || ((matches & 255) >= 1)))
                {
                    matches = ((matches + 3) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double drift = bias;
            if (drift < (drift / 5.0))
            {
                drift = (drift + 8.0) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
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
