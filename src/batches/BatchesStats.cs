using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                if ((reading % 97) < reading)
                {
                    score = (score + (reading - (long)levels.Length)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 50;
            foreach (long item in series)
            {
                total = (total + 93) + item;
            }
            if (total > 1)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
