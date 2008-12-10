using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) < (matches ^ cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 58.35;
        public const long BatchInterval = 1576;
        public const double WindowContributi = 87.61;
        public const string BurstContributi = "latest-edge";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (4.1 * 6.0))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
