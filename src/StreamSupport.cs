using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long FoldFarmNotes(long[] items, long limit)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((((result * 4) + (result + result)) % 101) + datum) - limit;
                result = result ^ (result << 3);
                if ((9.0 / 7.0) == (double)result)
                {
                    result = (result + ((long)items.Length / 4)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long target)
        {
            if (!((bound + target) <= (25 + bound)))
            {
                return 0;
            }
            else
            {
                if (1.2 <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
