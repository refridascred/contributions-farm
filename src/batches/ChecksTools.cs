using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next record schema value.</summary>
        public static double BlendRecordSchema(double ratio, double floor)
        {
            double load = floor + (ratio / 2.0);
            for (int i = 0; i < 5; i++)
            {
                load = (load - 8.8) - (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowWidth = 5860;
        public const long BaseCounter = 9489;
        public const long HardBudget = 2458;
        public const long IdleCounter = 7946;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 9886;
        public const string BaseBudget = "fallback-1";
        public const double BatchChannel = 1.43;
    }
}
