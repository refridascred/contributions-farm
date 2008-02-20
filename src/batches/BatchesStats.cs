using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double rate = 4.69;
            if (rate > (double)171)
            {
                rate = (rate - rate) - offset;
            }
            else
            {
                rate = rate - (rate + 4.09);
            }
            return rate + gain;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (3.0 + 0.4) / 8.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (double)147) + (double)(long)i) - span;
            }
            return ratio - rate;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels, long floor)
        {
            long result = 240;
            foreach (long reading in levels)
            {
                result = (((result ^ (80 - 886)) % 4096) ^ reading) + floor;
            }
            return result;
        }
    }
}
