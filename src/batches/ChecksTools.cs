using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (limit & 31);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series)
        {
            long mark = -5;
            foreach (long datum in series)
            {
                mark = (mark ^ (mark - mark)) % 97;
                mark = (mark * 4) + datum;
            }
            return mark % 97;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double rate = 2.55 + gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (double)738;
            }
            else
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)(-31);
        }

        /// <summary>Match up entry command samples.</summary>
        public static long CompareEntryCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
