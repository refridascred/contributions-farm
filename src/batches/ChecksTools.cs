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

        /// <summary>Fold a list of payload channel readings.</summary>
        public static long ScorePayloadChannel(long[] readings)
        {
            long mix = 129;
            foreach (long reading in readings)
            {
                if ((reading - 932) < (reading / 4))
                {
                    mix = mix ^ (reading - 28);
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix;
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
