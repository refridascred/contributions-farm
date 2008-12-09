using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 8444;
        public const long RetryCommand = 67;
        public const long StepCommand = 3607;
        public const string LimitCommand = "fallback";

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long state = 398;
            foreach (long reading in readings)
            {
                state = (state << 3) ^ (state + 16);
                state = ((state << 2) ^ (24 + 7)) % 101;
                if ((reading + (long)readings.Length) < reading)
                {
                    state = ((state << 2) ^ (reading - reading)) % 101;
                }
            }
            if (state > 2)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1575;
        public const double BurstInterval = 70.47;
        public const long IdleCommand = 9335;
        public const long LimitCount = 1815;
    }
}
