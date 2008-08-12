using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long sum = -9;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum ^ (seed % 16)) % 1000) ^ (long)i;
                    sum = (sum + (reading * 3)) % 65521;
                }
                sum = ((sum << 2) ^ (reading * 5)) % 97;
                if ((seed % 24) >= seed)
                {
                    sum = (sum * 5) + (177 + seed);
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Active,
            Queued,
            New,
        }
    }
}
