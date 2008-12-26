using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 8811;
        public const double BurstRecord = 77.2;
        public const string HardRecord = "open-edge";
        public const long StepFactor = 6874;
        public const double SoftRecord = 36.55;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count == (12.0 * 8.7))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Pending,
            Paused,
            Retry,
        }
    }
}
