using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                acc = (acc - (acc - acc)) - reading;
            }
            if (acc > (-5))
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Queued,
            Pending,
            Done,
        }
    }
}
