using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry >= target) || !(entry < (entry + target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next payload counter value from a seed.</summary>
        public static long RollPayloadCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 3) ^ (305 >> 5)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
