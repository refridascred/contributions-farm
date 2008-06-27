using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (mix << 3)) % 4096) - (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 97) - (long)i2;
                }
                mix = (mix + (item << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data, long target)
        {
            long result = 445;
            foreach (long cell in data)
            {
                result = (result << 3) ^ (cell + target);
            }
            if (result > 9)
            {
                result = result - (target / 5);
            }
            return result % 4096;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Dropped,
            Failed,
        }
    }
}
