using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            Queued,
            Draft,
            New,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series, long bound)
        {
            long mix = 61;
            foreach (long cell in series)
            {
                mix = mix - (cell % 100);
                if ((bound >> 5) > (bound << 3))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((17.0 * 7.0) != (double)offset)
                {
                    state = (state << 2) ^ (offset % 60);
                    state = ((state * 2) + offset) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + state) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
