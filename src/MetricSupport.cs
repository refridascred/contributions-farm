using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long target)
        {
            if ((2.46 + 4.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((target % 100) > (125 ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] levels, long offset)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = ((acc * 5) + (item >> 1)) % 255;
                if (!((acc % 12) < offset))
                {
                    break;
                }
            }
            if (acc < (-861))
            {
                acc = acc - (acc >> 5);
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
