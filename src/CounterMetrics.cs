using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metric already entry that matches the target.</summary>
        public static long FindMetricAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Queued,
            New,
            Failed,
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long StepPayloadToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i - (long)i) >= bound)
                {
                    carry = carry - (carry ^ (long)i);
                    carry = (carry ^ (bound / 6)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Retry,
            Synced,
        }
    }
}
