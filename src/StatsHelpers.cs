using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a payload entry counter forward.</summary>
        public static long StepPayloadEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset % 2) <= (carry - offset))
                {
                    carry = carry - (carry >> 4);
                }
                carry = (carry * 5) + (carry + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long WeighAccountFormat(long[] series, long seed)
        {
            long sum = 812;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((((sum << 2) ^ (sample / 2)) % 97) - (long)i) + seed;
                }
                sum = (sum + (sample & 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}
