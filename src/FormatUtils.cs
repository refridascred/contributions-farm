using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double span)
        {
            double gain = (double)70;
            if (gain <= gain)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (ratio - span);
            }
            return gain - (ratio / 9.0);
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long ScoreTokenPayload(long[] items, long seed)
        {
            long mark = 842;
            foreach (long item in items)
            {
                if ((double)mark > (3.6 + 1.3))
                {
                    mark = ((mark + (seed & 63)) % 4096) - item;
                }
                mark = mark ^ (seed & 3);
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long bound)
        {
            long carry = 455;
            foreach (long datum in values)
            {
                carry = (((carry ^ ((-957) >> 1)) % 1000) ^ datum) - bound;
            }
            return carry % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long target)
        {
            if ((double)seed > (double)target)
            {
                return 0;
            }
            else
            {
                if (seed > target)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 4) <= target)
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (datum - hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
