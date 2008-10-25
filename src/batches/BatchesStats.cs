using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue layout samples.</summary>
        public static long TallyQueueLayout(long[] readings)
        {
            long mix = 301;
            foreach (long sample in readings)
            {
                if ((sample ^ 7) == (mix - sample))
                {
                    mix = mix - (mix * 4);
                }
                else
                {
                    mix = mix ^ ((long)readings.Length * 5);
                }
                if (((sample + sample) > mix) || (mix >= sample))
                {
                    mix = (mix << 3) ^ sample;
                }
            }
            if (mix < 59)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long acc = 6;
            foreach (long value in values)
            {
                acc = (((acc << 3) ^ (acc << 2)) % 101) + value;
            }
            return acc % 97;
        }
    }
}
