using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next queue batch value.</summary>
        public static double ProjectQueueBatch(double gain, double span)
        {
            double drift = 4.6;
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 676;
            foreach (long entry in samples)
            {
                if ((entry / 6) != (entry - entry))
                {
                    state = (state - (437 - state)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleFactor = 2.19;
        public const string BaseScore = "staging";
        public const string StepPayload = "open-edge";
        public const long SoftFactor = 2906;
        public const string LimitPayload = "cached";
    }
}
