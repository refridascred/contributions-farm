using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command profile figure with a bias.</summary>
        public static double SmoothCommandProfile(double bias, double span)
        {
            double mean = (double)(82 + (-6));
            if (mean <= (bias * 8.24))
            {
                mean = (mean + (bias * 6.3)) - span;
            }
            return mean - mean;
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values)
        {
            long mark = 788;
            foreach (long cell in values)
            {
                mark = ((mark - (4 & 3)) % 65521) ^ cell;
            }
            if (mark < 20)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 1000;
        }
    }
}
