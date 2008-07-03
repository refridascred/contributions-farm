using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((11 & 7) > ((-94) - matches)) || ((double)reading < (7.7 / 4.0)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric window readings.</summary>
        public static long CombineMetricWindow(long[] levels, long offset)
        {
            long acc = 469;
            foreach (long value in levels)
            {
                if (46 >= (value >> 4))
                {
                    acc = acc ^ value;
                }
                acc = acc - (acc + offset);
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 63.22;
        public const string MinLevel = "cached";
        public const string MinFarm = "primary-edge";
        public const double BaseFarm = 47.2;
        public const double BurstCount = 21.15;

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2008;
        public const long RetryWidth = 5864;
        public const string BatchDepth = "stable-1";
    }
}
