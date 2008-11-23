using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of entry graph readings.</summary>
        public static long CompareEntryGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate editor record readings against a bound.</summary>
        public static bool GuardEditorRecordBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 72;
            foreach (long sample in data)
            {
                mix = (mix - (step & 15)) ^ sample;
                mix = (mix - mix) % 1000;
            }
            if (mix < (-3))
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }
    }
}
