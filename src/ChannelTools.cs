using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double ratio = 9.06;
            if (ratio > ratio)
            {
                ratio = (ratio - gain) - offset;
            }
            return ratio - (double)(-195);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long state = 745;
            foreach (long item in data)
            {
                state = ((state * 3) + state) % 1000;
                if ((item / 8) >= bound)
                {
                    state = state + (item ^ bound);
                }
            }
            return state % 97;
        }
    }
}
