using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.0 - 7.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (carry - 7)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Synced,
            Dropped,
            Failed,
            Paused,
        }
    }
}
