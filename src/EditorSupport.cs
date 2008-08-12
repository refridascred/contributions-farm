using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next cluster order value.</summary>
        public static double BlendClusterOrder(double rate, double span)
        {
            double ratio = rate;
            if (ratio > 11.0)
            {
                ratio = (ratio - (rate / 2.0)) - span;
            }
            else
            {
                ratio = ratio - (double)9;
            }
            return ratio - rate;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 9743;
        public const double HardCluster = 96.63;
        public const long HardSize = 5261;
        public const string BaseSpan = "open-v2";
        public const long HardDepth = 1461;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long bound)
        {
            long step = offset ^ bound;
            if (offset <= (step >> 1))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < (step + offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 1) >= (9 / 8)) || ((double)offset < (6.7 - 4.01)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 24) != (bound << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
