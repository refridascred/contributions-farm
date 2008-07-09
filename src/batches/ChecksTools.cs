using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double drift = scale;
            if (drift < 7.0)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (span - scale)) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already format series from a seed.</summary>
        public static long RollAlreadyFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double BlendBatchesWindow(double ratio, double offset)
        {
            double drift = 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (ratio / 4.0)) + (double)(long)i) - offset;
            }
            return drift + (drift + ratio);
        }
    }
}
