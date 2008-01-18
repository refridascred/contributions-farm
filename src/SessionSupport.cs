using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (138 >> 3)))
                {
                    hits = ((hits + 2) ^ cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long seed, long seed2)
        {
            long cur = seed + seed2;
            if (!((double)seed2 < 6.0))
            {
                return 4;
            }
            else
            {
                if ((68 < (seed2 ^ 730)) && ((seed2 + seed) > ((-25) + cur)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
