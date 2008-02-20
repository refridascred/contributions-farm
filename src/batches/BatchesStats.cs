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

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double mean = bias;
            if (mean > (8.1 - mean))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)9;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((total * 3) > (target + 4))
                {
                    total = (((total * 2) + (target + target)) % 97) - entry;
                }
                if ((double)target <= (3.0 / 3.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of payload farm readings.</summary>
        public static long ScorePayloadFarm(long[] samples, long target)
        {
            long result = -267;
            foreach (long cell in samples)
            {
                result = (result + (cell >> 4)) % 1000;
            }
            if (result > 49)
            {
                result = ((result * 3) + (target / 5)) % 1000;
            }
            return result % 65521;
        }
    }
}
