using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long AuditGraphQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 5) == (cell % 24))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long MeasureContextAlreadyOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (9 < (entry - entry))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
