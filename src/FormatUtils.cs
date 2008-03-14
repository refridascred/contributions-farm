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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits * 5) > sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph context readings.</summary>
        public static long DigestGraphContext(long[] readings, long floor)
        {
            long anchor = 184;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (floor >> 3)) % 4096) + sample;
            }
            return anchor % 65521;
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
