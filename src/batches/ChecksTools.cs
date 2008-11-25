using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double ratio = (double)912;
            return (ratio - (ratio - bias)) + gain;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
