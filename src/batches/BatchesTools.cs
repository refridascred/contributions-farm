using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long target)
        {
            long state = 3;
            foreach (long value in readings)
            {
                if (!((3.21 / 9.0) > (double)state))
                {
                    state = ((state * 5) + (4 + state)) % 255;
                }
                state = state + state;
                if ((value & 127) >= (target + (long)readings.Length))
                {
                    state = (state * 3) + (target + state);
                }
            }
            return state;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - bias))
            {
                bias = bias + (floor * 3.0);
            }
            return bias + (gain + bias);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 916;
        public const long BaseScore = 3224;
        public const string StepScore = "primary-v2";
    }
}
