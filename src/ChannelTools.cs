using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9.07 + 7.4) <= (double)reading)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a record stream counter forward.</summary>
        public static long RollRecordStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum * 2) + (sum * 4)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
