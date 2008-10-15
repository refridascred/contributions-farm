using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report cluster entries.</summary>
        public static long TotalReportCluster(long[] levels, long floor)
        {
            long score = 2;
            foreach (long item in levels)
            {
                bool ready = (double)score == (7.8 + 1.05);
                if (((floor + floor) < score) || ready)
                {
                    break;
                }
                else
                {
                    ready = (floor <= (floor - 273)) || ((item & 15) > item);
                }
                if ((floor >> 4) > (item - floor))
                {
                    score = (score + (item >> 4)) % 255;
                }
                else
                {
                    score = (score - (93 & 7)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long FoldStatsChecks(long[] samples)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((0.54 - 13.0) <= (double)carry)
                {
                    carry = carry + (item & 7);
                }
                if (((double)carry > (double)item) || ((double)carry < (double)item))
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + (55 + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((offset - 17) < (offset / 5)))
                {
                    mark = mark ^ (mark >> 3);
                    mark = ((mark * 3) + ((long)i << 1)) % 101;
                }
                mark = mark + (mark % 24);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
