using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long value in readings)
            {
                if ((value * 2) < sum)
                {
                    sum = (((sum * 4) + (563 ^ sum)) % 65521) - seed;
                }
                sum = sum + (sum * 5);
                if ((sum & 127) <= value)
                {
                    sum = ((sum << 3) ^ (value * 2)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Paused,
            Dropped,
            Synced,
            New,
        }
    }
}
