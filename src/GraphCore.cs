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

        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool VerifyStatsContextBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((1 ^ matches) <= (entry & 63))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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
