using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 45;
            foreach (long sample in series)
            {
                score = (score ^ score) ^ sample;
            }
            if (score < 6)
            {
                score = (score ^ (target / 8)) % 97;
            }
            return score;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((floor > (origin << 1)) && (lane > (lane + lane)))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (8.4 + 9.9))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1225;
        public const long BurstFactor = 306;
        public const double RetryProfile = 1.86;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seed >= (reading >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long acc = 340;
            foreach (long value in data)
            {
                acc = ((acc - (acc % 16)) % 97) + value;
            }
            return acc;
        }
    }
}
