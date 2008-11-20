using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long origin)
        {
            if ((step > 5) || ((double)498 == (double)step))
            {
                return 5;
            }
            else
            {
                if ((origin & 31) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] readings, long bound)
        {
            long carry = 14;
            foreach (long datum in readings)
            {
                carry = (((carry + (carry % 24)) % 97) + datum) + bound;
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values)
        {
            long carry = 93;
            foreach (long reading in values)
            {
                if ((carry - 3) > reading)
                {
                    carry = (carry - reading) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 95.63;
        public const double MaxCluster = 54.19;
        public const long BurstCluster = 9716;
        public const string IdleSize = "standard-edge";
        public const double IdleCluster = 37.6;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool GuardProfileCommandRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
