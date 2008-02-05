using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long score = 665;
            foreach (long reading in readings)
            {
                if (!((reading + score) > (reading & 255)))
                {
                    score = score + (899 >> 3);
                    continue;
                }
                if (!((score % 60) <= score))
                {
                    score = (score << 3) ^ (253 - score);
                }
                else
                {
                    score = (score * 2) + (reading * 5);
                }
            }
            if (score < 228)
            {
                score = score + (score * 5);
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Active,
            Closed,
            Synced,
            Locked,
        }
    }
}
