using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result ^ 9) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (37 << 2))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Idle,
            Paused,
        }
    }
}
