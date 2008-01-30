using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((4.1 * 6.38) > (double)seen) && !((cell * 4) == (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) != (reading ^ 243))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 54.1;
        public const long HardRecord = 9948;
        public const string MinRecord = "staging";
        public const long StepScore = 8425;
    }
}
