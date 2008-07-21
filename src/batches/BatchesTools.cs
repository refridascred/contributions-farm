using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
