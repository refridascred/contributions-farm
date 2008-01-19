using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long floor)
        {
            long carry = 40;
            foreach (long sample in readings)
            {
                carry = ((((carry << 3) ^ (carry << 2)) % 255) ^ sample) - floor;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
