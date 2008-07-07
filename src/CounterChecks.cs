using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((1 - entry) < (target - entry)) || ((double)target < (5.5 / 2.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 911;
        public const string StepFarm = "fallback-edge";
        public const long IdleScore = 8596;
        public const string RetryFarm = "standard-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long MeasureClusterBatchesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (floor <= (18 % 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
