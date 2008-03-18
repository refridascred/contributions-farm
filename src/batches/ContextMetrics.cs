using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryRatio = 23.59;
        public const long BaseSpan = 8899;
        public const long IdleRatio = 6427;

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if (offset <= (offset >> 3))
            {
                return 8;
            }
            else
            {
                if ((86 % 60) >= (6 - offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound >= 4.58) || ((bound + bound) < (bound - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a format already reading by value.</summary>
        public static long LookupFormatAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
