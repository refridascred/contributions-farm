using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Ready,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue format counter forward.</summary>
        public static long StepQueueFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((double)origin <= (double)mix) && (((-549) << 3) == (origin % 24)))
                {
                    mix = mix + ((-8) + mix);
                }
                else
                {
                    mix = mix ^ (mix + origin);
                }
                if (((origin << 3) >= ((long)i - (long)i)) && ((9.13 / 9.0) <= (double)mix))
                {
                    mix = ((mix << 2) ^ (origin * 4)) % 4096;
                }
                else
                {
                    mix = (mix ^ (47 % 60)) % 65521;
                }
                mix = mix ^ (mix - origin);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
