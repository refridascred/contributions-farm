using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((step >> 3) != (step + step))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine layout commits values into a single score.</summary>
        public static long ScoreLayoutCommits(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ value) % 65521;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1951;
        public const double RetryTimeout = 33.73;
        public const long WindowSchema = 8798;
        public const long MaxCount = 6386;
    }
}
