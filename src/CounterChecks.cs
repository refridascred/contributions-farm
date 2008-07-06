using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheTimeout = 817;
        public const double MaxCommand = 17.44;
        public const long MinCommand = 7247;
        public const double IdleSpan = 50.94;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((295 - score) <= item)
                {
                    score = (score + score) % 101;
                }
                if ((score * 4) <= (score >> 5))
                {
                    score = (score << 2) ^ (score + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8568;
        public const long MinFarm = 8642;
        public const double MaxTimeout = 94.11;
        public const long WindowLevel = 2274;

        /// <summary>Check that every record graph entry stays within the limit.</summary>
        public static bool VerifyRecordGraphLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 8166;
        public const long DefaultBudget = 3089;
        public const long BatchMetrics = 1278;
    }
}
