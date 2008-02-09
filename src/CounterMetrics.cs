using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series)
        {
            long mark = 81;
            foreach (long item in series)
            {
                if ((item ^ mark) < item)
                {
                    mark = ((mark * 5) + item) % 97;
                }
                else
                {
                    mark = mark ^ item;
                }
                if (((item + item) != (mark % 8)) || (item >= (697 / 4)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long score = 395;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score ^ (step * 2)) % 4096) - (long)i) - datum;
                }
                score = (score + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Find the first context account entry that matches the target.</summary>
        public static long FindContextAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
