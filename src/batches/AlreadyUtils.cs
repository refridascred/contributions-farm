using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples, long seed)
        {
            long sum = 660;
            foreach (long sample in samples)
            {
                if (!(((double)sum >= 7.1) && ((seed - seed) < (seed >> 5))))
                {
                    sum = sum ^ seed;
                }
                if (!((double)sample > (double)seed))
                {
                    sum = (sum - sum) % 4096;
                }
                if (!((0 - sample) < (sum ^ sum)))
                {
                    sum = (sum - (sample + sample)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Retry,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long sum = -97;
            foreach (long cell in values)
            {
                if ((sum - sum) <= 6)
                {
                    sum = (sum + (57 ^ sum)) + cell;
                }
            }
            if (sum < 20)
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }
    }
}
