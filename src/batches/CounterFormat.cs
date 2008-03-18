using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue command entries that pass the check.</summary>
        public static long TallyQueueCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((-952) >> 1) > (hits & 31)) && ((hits * 3) > (1 - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((94 + count) == (sample ^ count)) && ((count - count) <= (sample % 5))) || (((long)samples.Length + count) == (436 * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 98;
            foreach (long sample in series)
            {
                mix = ((mix * 5) + (sample - 8)) % 255;
            }
            if (mix < 311)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 4096;
        }
    }
}
