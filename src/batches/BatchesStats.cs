using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 76;
            foreach (long entry in readings)
            {
                if (!((entry + entry) != (score + score)))
                {
                    score = ((score * 2) + entry) % 65521;
                    break;
                }
                else
                {
                    score = score + entry;
                }
                if (((double)score < (double)(long)readings.Length) || ((436 + entry) < (score % 64)))
                {
                    score = score + entry;
                }
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
