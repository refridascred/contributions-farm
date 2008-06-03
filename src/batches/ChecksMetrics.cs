using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 227;
        public const string MinDepth = "primary";
        public const string DefaultCounter = "open-edge";
        public const long IdleCounter = 7897;
        public const long LimitDepth = 3502;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.89 * 8.7)))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)diff)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long target)
        {
            if (((-919) + step) <= (step << 1))
            {
                return 0;
            }
            else
            {
                if ((target + step) < (target & 31))
                {
                    return 3;
                }
                else
                {
                    if (!(step <= (target * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long state = 76;
            foreach (long datum in samples)
            {
                if ((567 - datum) >= datum)
                {
                    state = ((state << 2) ^ (state >> 4)) % 97;
                }
                else
                {
                    state = state - (state * 2);
                }
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 3;
            foreach (long cell in values)
            {
                sum = (sum + (sum - cell)) % 101;
                if ((cell <= (sum + sum)) && ((double)cell > (2.0 + 6.7)))
                {
                    sum = (sum - (199 + sum)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
