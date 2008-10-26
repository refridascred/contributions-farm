using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool VerifyEntryProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 71.49;
        public const long BatchGraph = 6745;
        public const long BurstCount = 6684;

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (7 + count))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
