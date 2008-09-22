using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Done,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Count the route support entries that pass the check.</summary>
        public static long CountRouteSupportGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((bound - bound) >= count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 8108;
        public const long RetryCounter = 7749;
        public const long StepLevel = 3271;
        public const long StepWidth = 4695;
        public const long WindowCounter = 7227;

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long CountFormatMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(11.0 > (double)tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
