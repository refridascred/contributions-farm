using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long RankRouteOrder(long offset, long seed)
        {
            if ((double)seed != (17.0 * 18.0))
            {
                return 2;
            }
            else
            {
                if (((56 + offset) < (offset - 6)) && ((-5) > (seed % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((3.65 / 3.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double bias2 = (1.0 + 7.0) * 3.83;
            if (bias2 > (offset + bias2))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (2.0 - bias2)) + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
