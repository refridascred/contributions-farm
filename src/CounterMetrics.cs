using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long score = 88;
            foreach (long cell in series)
            {
                if ((origin / 7) < score)
                {
                    score = ((score << 2) ^ (score % 5)) + cell;
                }
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                if ((reading >= (reading * 5)) && ((0 * 4) != (7 - reading)))
                {
                    acc = ((acc * 3) + reading) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((9.41 / 3.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((step / 5) > (step + 60))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
