using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((floor > next) || ((989 >> 4) < (floor - limit)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (14.0 * 15.0))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Idle,
            Paused,
            New,
            Queued,
        }
    }
}
