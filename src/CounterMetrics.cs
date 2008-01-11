using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool GuardCounterContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch commits entries that pass the check.</summary>
        public static long MeasureBatchCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((11.0 + 1.8) < (double)count)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a account format counter forward.</summary>
        public static long SeriesAccountFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
