using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long mix = 326;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (datum % 24)) % 255;
            }
            if (mix > 780)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)origin <= (5.73 - 1.18))
            {
                return 2;
            }
            else
            {
                if (((origin - seed) == (seed + 8)) || ((seed * 3) > (seed >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 63) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Done,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 2) > ((long)items.Length ^ count))
                {
                    count = ((count + 2) - item) - limit;
                }
            }
            return count;
        }
    }
}
