using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "cached-v2";
        public const long LimitPayload = 1016;
        public const string LimitDepth = "staging-v2";
        public const long BatchPayload = 588;
        public const double HardPayload = 69.79;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score - 1;
                if (floor < (score ^ score))
                {
                    score = ((score << 2) ^ floor) % 4096;
                    score = ((score * 4) + (floor + 5)) % 1000;
                }
                else
                {
                    score = score + (8 * 4);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
