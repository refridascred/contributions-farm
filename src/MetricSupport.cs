using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long result = 21;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (limit + limit)) % 1000;
                if ((reading >> 3) != (210 + 9))
                {
                    result = (result << 3) ^ (limit + 52);
                }
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long seed2)
        {
            if ((seed << 2) < (seed * 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed2) > seed2)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ 142) >= (seed & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (((score << 2) ^ (bound % 97)) % 97) ^ (long)i2;
                }
                score = score ^ (score + bound);
                if ((631 << 2) != ((long)i >> 2))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
