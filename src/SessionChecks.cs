using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 333;
        public const double StepGraph = 43.73;
        public const long DefaultGraph = 7208;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.66 - 5.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = -51;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum * 3) + ((long)i & 7);
                    sum = (sum << 2) ^ (reading * 2);
                }
                sum = ((sum * 4) + (sum * 2)) % 65521;
            }
            return sum;
        }
    }
}
