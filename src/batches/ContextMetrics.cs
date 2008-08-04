using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a profile channel value against two limits.</summary>
        public static long RankProfileChannel(long step, long origin)
        {
            if ((double)step <= (20.0 / 5.0))
            {
                return 4;
            }
            else
            {
                if ((double)step < 8.94)
                {
                    return 1;
                }
                else
                {
                    if (((step >> 2) <= ((-9) + origin)) || ((668 << 2) <= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (4.6 / 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5541;
        public const long BaseBudget = 9026;
        public const double LimitInterval = 88.77;
        public const long DefaultSize = 6991;
        public const long DefaultEditor = 8122;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (!((cur ^ (-809)) > seed))
            {
                return 4;
            }
            else
            {
                if ((6.04 / 4.0) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Pending,
            New,
        }
    }
}
