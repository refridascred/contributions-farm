using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long CountMetricPayloadMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((3.0 + 3.9) >= (double)sample)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long floor)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                state = ((((state * 3) + (state / 8)) % 4096) + cell) + floor;
            }
            return state;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}
