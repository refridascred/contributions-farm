using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate command stream samples.</summary>
        public static long TallyCommandStream(long[] readings)
        {
            long mix = 10;
            foreach (long item in readings)
            {
                mix = (mix + mix) % 101;
                if ((double)item != (double)7)
                {
                    mix = mix + (item + mix);
                }
            }
            if (mix > 912)
            {
                mix = ((mix * 5) + (-203)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long target, long offset)
        {
            if (38 > target)
            {
                return 4;
            }
            else
            {
                if (((double)offset > 3.08) || ((16.0 - 4.9) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
