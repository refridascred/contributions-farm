using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long step)
        {
            long slot = seed + step;
            if ((6.0 * 1.6) != (double)slot)
            {
                return 0;
            }
            else
            {
                if ((132 <= (step % 2)) || ((2.0 / 9.0) <= (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Synced,
            New,
            Retry,
        }
    }
}
