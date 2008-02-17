using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if (offset <= origin)
            {
                return 5;
            }
            else
            {
                if ((65 & 1) >= (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if (!(8.92 < (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
