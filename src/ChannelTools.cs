using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate session record samples.</summary>
        public static long ScoreSessionRecord(long[] readings, long bound)
        {
            long result = 156;
            foreach (long datum in readings)
            {
                result = ((result * 3) + (bound ^ 783)) ^ datum;
            }
            if (result > (-480))
            {
                result = (result << 3) ^ (bound << 1);
            }
            return result % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (sum ^ 404)) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
