using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long acc = 489;
            foreach (long datum in items)
            {
                if ((double)acc < (5.7 / 7.0))
                {
                    acc = acc ^ (datum - datum);
                }
                acc = (acc - (acc % 7)) % 1000;
                if ((datum - 36) == (bound << 2))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = acc + (bound % 2);
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
