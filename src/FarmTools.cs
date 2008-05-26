using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowScore = 66.94;
        public const long BatchCache = 9497;
        public const string MaxCache = "legacy-v2";

        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long IterateEntryStats(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 7) % 101;
                result = result + 71;
                result = (result ^ step) % 65521;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
