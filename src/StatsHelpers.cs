using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a cluster queue value against two limits.</summary>
        public static long GradeClusterQueue(long seed, long origin)
        {
            if ((seed - seed) > (seed & 127))
            {
                return 1;
            }
            else
            {
                if (((seed + 307) >= (origin + 662)) || (205 < origin))
                {
                    return 8;
                }
                else
                {
                    if ((99 & 255) < (seed % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 60) <= (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double gain = (offset - offset) * 7.5;
            return (gain - 14.0) + ratio;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= (datum >> 1))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "standard-1";
        public const double HardBatch = 82.6;
        public const long BaseBatch = 3806;
    }
}
