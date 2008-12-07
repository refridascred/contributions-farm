using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit queue filter readings against a rule.</summary>
        public static long CountQueueFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen != (5.0 + 12.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
