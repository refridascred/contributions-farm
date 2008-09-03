using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 1752;
        public const long WindowReport = 1202;
        public const string MaxDepth = "strict";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor >= (3 - floor))
                {
                    score = (score * 4) + floor;
                    break;
                }
                if ((score >> 1) < (score & 255))
                {
                    score = (score * 3) + (long)i;
                }
                else
                {
                    score = (score ^ (score << 3)) % 65521;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
