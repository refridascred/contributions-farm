using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + matches) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long mark = -893;
            foreach (long value in series)
            {
                mark = mark ^ value;
            }
            if (mark < 64)
            {
                mark = ((mark * 4) + (497 ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long seed)
        {
            long lane = step + seed;
            if (!(seed < step))
            {
                return 0;
            }
            else
            {
                if ((seed + lane) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) == (99 - 40)) || (61 >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((950 + step) < (step ^ lane))
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
        }
    }
}
