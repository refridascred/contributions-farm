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

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Ready,
            Idle,
            Draft,
            Failed,
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

        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool CheckTokenBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
