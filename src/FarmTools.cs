using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                long matches = (long)i;
                if (!!((matches & 3) >= (acc / 8)))
                {
                    matches = ((matches << 3) ^ (long)i) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long state = 67;
            foreach (long item in samples)
            {
                if ((double)state < (10.0 - 15.0))
                {
                    state = (state + (item - state)) % 65521;
                }
                state = (state - (147 & 255)) % 255;
            }
            return state;
        }
    }
}
