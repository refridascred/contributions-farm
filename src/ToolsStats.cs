using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1788;
        public const double HardRatio = 19.78;
        public const long StepWidth = 2342;
        public const long RetryFormat = 2904;
        public const long BaseScore = 6348;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (bias - bias)) - (double)(long)i) - scale;
            }
            return bias + (double)56;
        }

        /// <summary>Find the first account queue entry that matches the target.</summary>
        public static long LookupAccountQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long offset2)
        {
            long delta = offset - offset2;
            if ((delta - delta) == (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset * 4) > (offset2 & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowWidth = "primary-edge";
        public const long IdleScore = 1595;
        public const double RetryScore = 51.67;
    }
}
