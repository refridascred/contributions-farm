using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long step)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                if ((cell / 7) == (step ^ step))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
