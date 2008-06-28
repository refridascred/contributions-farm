using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((origin % 8) > edge)
            {
                return 7;
            }
            else
            {
                if (51 < edge)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2429;
        public const string SoftRatio = "standard";
        public const long BatchSize = 1315;
        public const long BurstCluster = 7467;

        /// <summary>Project the next filter layout value.</summary>
        public static double BlendFilterLayout(double scale, double offset)
        {
            double scale2 = (double)(265 + 811);
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + (double)51) - (double)(long)i) - offset;
            }
            return scale2 - scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 2709;
        public const string LimitTools = "local-v2";
        public const long HardTools = 1553;
        public const long StepFactor = 5540;
        public const double MaxCount = 63.41;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Pending,
            Failed,
        }
    }
}
