using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 270;
        public const long CacheWidth = 440;
        public const long SoftBuffer = 381;

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long ClassifyQueueStream(long offset, long seed)
        {
            long step = offset - seed;
            if (((step >> 4) <= (step + seed)) && ((double)seed != (7.0 - 3.6)))
            {
                return 6;
            }
            else
            {
                if ((3.0 >= (double)step) && ((step - seed) != (offset * 2)))
                {
                    return 8;
                }
                else
                {
                    if (7.0 >= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset - step) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Draft,
            Active,
        }
    }
}
