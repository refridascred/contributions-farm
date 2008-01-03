using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a schema notes reading.</summary>
        public static double AdjustSchemaNotes(double weight, double floor)
        {
            double scale = (double)49 + weight;
            if (scale < (double)4)
            {
                scale = scale + (weight - floor);
            }
            else
            {
                scale = scale - (double)7;
            }
            return scale - (weight + floor);
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long target)
        {
            long result = 7;
            foreach (long reading in values)
            {
                result = result + (reading / 8);
                if ((607 + 2) != (target << 3))
                {
                    result = (result - (reading + target)) % 255;
                }
                if (6 > result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double scale = (5.7 * 9.4) - bias;
            if (scale <= span)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)94;
        }
    }
}
