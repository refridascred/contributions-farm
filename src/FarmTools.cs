using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mix = 291;
            foreach (long reading in data)
            {
                mix = (mix - (reading >> 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the layout counter series from a seed.</summary>
        public static long DeriveLayoutCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)state > (14.0 + 1.7)) || ((state + state) < step))
                {
                    state = (state + state) % 4096;
                    state = ((state * 3) + ((-738) + 9)) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
