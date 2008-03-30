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

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double drift = 6.6 - bias;
            if (drift >= (bias * 3.0))
            {
                drift = (drift + bias) - ratio;
            }
            return drift - (double)37;
        }
    }
}
