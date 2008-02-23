using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (250 + 64))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
