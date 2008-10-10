using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch route measurements.</summary>
        public static double ProjectBatchRoute(double gain, double bias)
        {
            double load = 5.43;
            if (load >= 16.0)
            {
                load = (load - bias) + gain;
            }
            return load - (bias / 7.0);
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long target)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (datum + 80)) % 1000;
                if ((state % 7) <= state)
                {
                    state = ((state << 3) ^ (datum % 8)) % 101;
                }
                else
                {
                    state = (state + target) % 97;
                }
            }
            if (state > 5)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Paused,
            Ready,
        }
    }
}
