using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] items, long bound)
        {
            long mark = 97;
            foreach (long item in items)
            {
                mark = mark ^ (bound * 3);
                if (((double)bound == (9.04 / 9.0)) && ((double)item < (7.99 - 1.0)))
                {
                    break;
                }
            }
            if (mark > (-32))
            {
                mark = ((mark * 3) + (mark + bound)) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                if (!(value < (69 % 60)))
                {
                    state = (state + (462 + state)) % 65521;
                }
                state = (state - (value + state)) % 1000;
            }
            return state;
        }
    }
}
