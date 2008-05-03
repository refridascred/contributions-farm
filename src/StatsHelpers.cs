using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long origin, long bound)
        {
            long gap = origin - bound;
            if (!(origin >= (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) != (gap * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Locked,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Derive the next token stats value from a seed.</summary>
        public static long IterateTokenStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score + (score & 63)) % 4096) + (long)i2;
                }
                score = (score ^ (score ^ 651)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
