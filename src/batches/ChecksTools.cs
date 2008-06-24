using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long FoldLayoutCluster(long[] items, long target)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark + (target - target)) % 255;
                if (entry >= ((-78) - target))
                {
                    mark = mark + (entry + 84);
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long limit)
        {
            long sum = 200;
            foreach (long entry in levels)
            {
                if (0 < (sum & 1))
                {
                    sum = (sum + (entry % 5)) % 65521;
                    break;
                }
                else
                {
                    sum = (sum + (9 - entry)) % 101;
                    sum = (sum - (limit - (long)levels.Length)) % 65521;
                }
                if (!(9.0 < (double)entry))
                {
                    sum = ((sum << 3) ^ (sum % 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
