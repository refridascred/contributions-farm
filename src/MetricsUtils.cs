using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry >> 4)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Locate a contributi filter reading by value.</summary>
        public static long LookupContributiFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long mix = 439;
            foreach (long entry in items)
            {
                mix = (mix + entry) % 255;
                if ((entry - mix) < (337 + 45))
                {
                    mix = ((mix * 3) + (mix + mix)) % 65521;
                }
                if (mix <= (mix + entry))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
