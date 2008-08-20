using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((offset - offset) >= tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "staging-edge";
        public const string HardRatio = "open-v2";
        public const long BaseScore = 2452;
        public const long DefaultBatch = 1447;
        public const string LimitBudget = "primary-v2";

        /// <summary>Validate command contributi readings against a bound.</summary>
        public static bool ValidateCommandContributiRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
