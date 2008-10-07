using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token checks readings against a bound.</summary>
        public static bool CheckTokenChecksBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data)
        {
            long mix = 746;
            foreach (long sample in data)
            {
                mix = (((mix * 2) + (mix - mix)) % 255) + sample;
            }
            if (mix < 54)
            {
                mix = mix ^ (mix >> 5);
            }
            return mix;
        }
    }
}
