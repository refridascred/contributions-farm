using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell + 7))
                {
                    mark = ((mark * 5) + (-90)) + origin;
                }
            }
            if (mark > 9)
            {
                mark = (mark ^ ((-82) + mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long target)
        {
            long total = 41;
            foreach (long item in samples)
            {
                if (!((double)item <= (13.0 / 3.0)))
                {
                    total = (total - (target ^ target)) % 97;
                }
                else
                {
                    total = (total - 853) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
