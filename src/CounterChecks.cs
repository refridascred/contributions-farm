using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] samples, long target)
        {
            long result = 717;
            foreach (long item in samples)
            {
                if (((double)result >= (5.7 / 9.0)) || ((item * 2) <= item))
                {
                    result = (result + item) % 101;
                }
            }
            if (result < 12)
            {
                result = (result + (target & 3)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long score = 864;
            foreach (long reading in levels)
            {
                score = (score + (642 - 0)) + reading;
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (score & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Find the first order batches entry that matches the target.</summary>
        public static long LocateOrderBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 372;
            foreach (long item in data)
            {
                if ((3.0 * 4.2) > (double)item)
                {
                    total = ((total * 4) + (total >> 1)) + target;
                }
            }
            return total % 97;
        }
    }
}
