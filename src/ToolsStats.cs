using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) >= (matches + 908))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Locked,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if (((floor / 4) == (183 + seed)) && ((95 + 2) >= (floor / 5)))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 5.76) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (!((206 % 7) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor > (8.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 2869;
        public const long LimitCache = 1557;
        public const double BatchCache = 57.0;
        public const long StepCache = 9121;
        public const long HardDepth = 8217;
    }
}
