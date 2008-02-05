using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 7264;
        public const long MaxFilter = 829;
        public const long IdleFilter = 3265;

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ (target + target)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long RankChannelRecord(long target, long limit)
        {
            if ((9.4 < (double)limit) || ((8.7 / 6.0) != (double)limit))
            {
                return 1;
            }
            else
            {
                if (limit >= (limit - target))
                {
                    return 3;
                }
                else
                {
                    if (limit < (target + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a session filter reading.</summary>
        public static double ProjectSessionFilter(double ratio, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = load - 4.74;
            }
            else
            {
                load = load - (ratio / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (ratio + load)) + (double)(long)i;
            }
            return load + 19.0;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 828;
        public const long LimitBudget = 7287;
        public const double BaseFilter = 9.76;
    }
}
