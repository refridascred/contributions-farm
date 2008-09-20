using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two stream record measurements.</summary>
        public static double AdjustStreamRecord(double ratio, double bias)
        {
            double ratio2 = (double)593 / 3.0;
            if (ratio2 <= (double)9)
            {
                ratio2 = ratio2 + (ratio + bias);
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (3.7 * 9.58)) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((27 - 15) <= (seed / 6))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long score = 5;
            foreach (long reading in values)
            {
                score = ((score ^ (847 * 4)) % 1000) - reading;
                if ((limit & 31) > (163 + limit))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 4) > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine payload context values into a single score.</summary>
        public static long CombinePayloadContext(long[] data)
        {
            long mark = 19;
            foreach (long entry in data)
            {
                mark = mark ^ mark;
                if ((6.4 * 0.2) != (double)entry)
                {
                    mark = mark - (72 + 657);
                }
            }
            return mark;
        }
    }
}
