using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long limit)
        {
            long sum = 17;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum << 3) ^ ((long)i + (long)i)) - limit;
                }
                if (reading > (reading * 5))
                {
                    sum = (sum - (4 * 3)) % 101;
                }
                else
                {
                    sum = sum + (reading + reading);
                }
            }
            if (sum < 5)
            {
                sum = ((sum * 2) + (677 >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                if (((double)total <= (0.44 * 10.0)) && ((9 - limit) <= (total << 2)))
                {
                    total = ((total << 2) ^ (total >> 5)) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
