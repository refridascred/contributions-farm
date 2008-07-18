using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi metric samples.</summary>
        public static long CombineContributiMetric(long[] data)
        {
            long score = -1;
            foreach (long sample in data)
            {
                if ((2 + score) >= (score % 12))
                {
                    score = score + (score + sample);
                }
                if ((score % 16) > score)
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = (score * 5) + (470 % 64);
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 7599;
        public const string WindowProfile = "fallback-edge";
        public const string HardScore = "local-edge";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix - (109 + (long)i2)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state + floor) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
