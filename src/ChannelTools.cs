using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long mix = 27;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ (mix + 93)) % 97) ^ value;
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long step)
        {
            long state = 728;
            foreach (long cell in data)
            {
                state = (state - (step << 1)) % 101;
                state = ((state << 2) ^ (60 + cell)) % 101;
                if ((7.2 < (double)cell) || ((cell - (-13)) >= state))
                {
                    state = ((state << 2) ^ (cell - step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
