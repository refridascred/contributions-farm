using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long TallyContributiNotes(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                acc = ((acc - acc) % 101) - sample;
            }
            return acc % 1000;
        }

        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool ValidateGraphAlreadyRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 2964;
        public const long MaxQueue = 2849;
        public const double WindowRatio = 27.27;
        public const long BatchQueue = 7526;
        public const long MinTimeout = 2283;
    }
}
