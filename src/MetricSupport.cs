using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up farm metric samples.</summary>
        public static long OverlapFarmMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)step < (1.76 + 4.5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Find the first session metric entry that matches the target.</summary>
        public static long FindSessionMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
