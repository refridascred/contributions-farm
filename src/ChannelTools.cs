using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] samples, long seed)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                state = (state + (state & 3)) % 4096;
                if (seed < (sample * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}
