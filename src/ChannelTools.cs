using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = 965;
            foreach (long item in readings)
            {
                result = (result + (item & 255)) % 65521;
            }
            if (result < 802)
            {
                result = (result - result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 3312;
        public const long WindowWidth = 9764;
        public const long HardBudget = 5427;
        public const long HardEditor = 5377;

        /// <summary>Match up context session samples.</summary>
        public static long OverlapContextSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
