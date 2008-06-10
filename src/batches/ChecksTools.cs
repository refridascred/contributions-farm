using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if ((seed * 4) > (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 768) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((76 << 3) >= (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 4) == (seed % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
