using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long score = 810;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 8) != (score % 12))
                {
                    score = (score - (item / 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum - (long)i) % 65521) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
