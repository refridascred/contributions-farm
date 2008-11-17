using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool ValidateFilterChecksBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long seed)
        {
            long acc = 837;
            foreach (long item in series)
            {
                acc = ((acc * 3) + (seed - 20)) + item;
            }
            if (acc < 3)
            {
                acc = ((acc * 4) + (acc << 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long sum = 929;
            foreach (long entry in readings)
            {
                sum = (sum - (59 - sum)) ^ entry;
            }
            return sum % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Synced,
            Paused,
            Failed,
        }
    }
}
