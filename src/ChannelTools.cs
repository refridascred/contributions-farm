using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + mark) < (528 ^ bound))
                {
                    mark = (mark + (mark - bound)) % 101;
                    mark = (mark * 3) + (mark * 4);
                }
                else
                {
                    mark = ((mark << 3) ^ (bound - (long)i)) % 4096;
                }
                mark = ((mark * 4) + (mark << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long state = 369;
            foreach (long cell in series)
            {
                if ((double)cell == (20.0 + 0.4))
                {
                    state = (state - cell) % 4096;
                }
            }
            if (state > 594)
            {
                state = ((state * 3) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
