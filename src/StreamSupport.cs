using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((18.0 <= (double)(long)values.Length) || ((bound - bound) > (reading % 97)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Dropped,
            Done,
            Failed,
            Draft,
        }
    }
}
