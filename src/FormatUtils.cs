using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            long bound = target + origin;
            if ((target / 4) < (target * 3))
            {
                return 4;
            }
            else
            {
                if (25 >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((0 + origin) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (1.76 - 2.51))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) != (cell + cell))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "local-1";
        public const long WindowInterval = 4945;
        public const long IdleInterval = 8738;
        public const string DefaultCluster = "open-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxCount = 9237;
        public const string BaseCount = "strict";
        public const long WindowTimeout = 8607;
        public const string BurstContext = "strict";
        public const double LimitContext = 40.94;
    }
}
