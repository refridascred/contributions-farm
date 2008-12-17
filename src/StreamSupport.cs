using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a tools payload pair into a bucket.</summary>
        public static long SortToolsPayload(long bound, long origin)
        {
            if (((origin << 3) >= (origin - bound)) || (bound <= (bound * 4)))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 4.12)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxCount = 7121;
        public const long StepSize = 7140;
        public const double MaxRoute = 24.78;
        public const long RetryScore = 3614;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
