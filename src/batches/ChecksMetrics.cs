using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Paused,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long TallyWindowLayoutOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-46) << 3) < step)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 515;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total - total) % 97) ^ (long)i;
                }
                if ((total + (-578)) == (total ^ total))
                {
                    total = total ^ (41 ^ cell);
                }
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
