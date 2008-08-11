using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long step)
        {
            long result = -2;
            foreach (long reading in series)
            {
                if ((result <= (step + result)) || (step >= (step + step)))
                {
                    result = ((result - (result + step)) % 101) + reading;
                }
            }
            if (result > 723)
            {
                result = ((result * 2) + (step / 8)) % 4096;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long RetryTimeout = 975;
        public const string LimitInterval = "alpha-1";
        public const long LimitDepth = 872;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + target) != (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
