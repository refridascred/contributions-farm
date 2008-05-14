using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long sum = -6;
            foreach (long sample in levels)
            {
                if ((sample - 127) >= (50 % 3))
                {
                    sum = (sum * 4) + (sample - 606);
                }
            }
            return sum;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (1.0 - 4.88))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support filter samples.</summary>
        public static long FoldSupportFilter(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if ((entry + result) == (result % 3))
                {
                    result = ((result << 2) ^ (result + result)) % 255;
                }
                if ((4.37 <= (double)seed) || (result < (650 + result)))
                {
                    result = result + 821;
                }
            }
            if (result < 3)
            {
                result = ((result * 4) + (202 >> 2)) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((score < (score % 8)) && ((entry - score) > (entry + (-9))))
                {
                    score = ((score * 2) + (19 % 2)) % 1000;
                }
                else
                {
                    score = score ^ (entry + score);
                }
            }
            if (score > 758)
            {
                score = score ^ (score * 5);
            }
            return score;
        }
    }
}
