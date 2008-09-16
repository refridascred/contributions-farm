using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long seed)
        {
            long carry = 787;
            foreach (long value in data)
            {
                carry = (((carry - (carry % 3)) % 97) ^ value) - seed;
            }
            return carry % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6 & 3) != (long)readings.Length)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Pending,
            Active,
            Paused,
        }
    }
}
