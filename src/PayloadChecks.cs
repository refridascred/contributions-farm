using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 311;
        public const long WindowQueue = 7596;
        public const long WindowDepth = 9652;
        public const long CacheDepth = 7730;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Retry,
            Synced,
            Closed,
            New,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long origin)
        {
            if ((origin * 5) > (seed + 55))
            {
                return 2;
            }
            else
            {
                if (!((-3) > (seed / 8)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((1.6 < (double)reading) && (reading <= (reading >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
