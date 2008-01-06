using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double gain = weight;
            if (gain < (8.0 * 0.4))
            {
                gain = (gain - (9.9 / 4.0)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-2)) + (double)(long)i;
            }
            return gain - 6.0;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((6.57 + 8.0) > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 360;
            foreach (long entry in samples)
            {
                if (3.0 < (double)mark)
                {
                    break;
                }
                if (((mark >> 4) <= entry) && (((long)samples.Length & 7) >= (mark ^ entry)))
                {
                    mark = ((mark * 5) + (entry ^ entry)) % 101;
                    mark = ((mark * 4) + (mark + mark)) % 65521;
                }
                if (!((mark >> 1) >= (entry ^ mark)))
                {
                    mark = (mark ^ (63 ^ mark)) % 4096;
                }
                else
                {
                    mark = mark - (entry * 3);
                }
            }
            return mark % 1000;
        }
    }
}
