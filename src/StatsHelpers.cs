using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long acc = 78;
            foreach (long value in series)
            {
                if ((acc - acc) < acc)
                {
                    break;
                }
                acc = acc - (acc & 7);
                if (((acc & 1) != (acc + value)) && (1.7 >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = ((acc * 2) + (acc / 8)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + 98) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long bound, long bound2)
        {
            if ((bound2 - bound) > (1 & 127))
            {
                return 1;
            }
            else
            {
                if ((27 + bound) == (bound << 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
