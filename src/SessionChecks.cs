using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double gain = (double)14 - bias;
            if (gain > 2.85)
            {
                gain = gain - 3.0;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(-967)) + (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long limit)
        {
            if ((3.8 - 12.0) == (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset < (limit & 31)) || ((double)limit > (double)132))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) > (offset - 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
