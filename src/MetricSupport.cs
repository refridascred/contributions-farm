using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric window samples.</summary>
        public static long WeighMetricWindow(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                sum = ((sum << 2) ^ (entry + entry)) % 255;
            }
            if (sum < 821)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long bound)
        {
            long mark = 585;
            foreach (long cell in samples)
            {
                if ((bound * 3) < (cell * 2))
                {
                    mark = (mark + (78 - mark)) % 65521;
                }
            }
            if (mark > 404)
            {
                mark = (mark ^ (mark ^ bound)) % 255;
            }
            return mark;
        }
    }
}
