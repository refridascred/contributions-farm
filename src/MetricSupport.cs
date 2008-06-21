using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long step)
        {
            long offset = origin + step;
            if ((double)36 != (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset < step)
                {
                    return 8;
                }
                else
                {
                    if (offset > (origin ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes filter readings.</summary>
        public static long OverlapNotesFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
