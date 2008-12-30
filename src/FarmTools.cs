using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Active,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (14.0 / 4.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
