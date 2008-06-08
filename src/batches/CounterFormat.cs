using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 4656;
        public const string LimitBudget = "fallback-edge";
        public const string WindowFactor = "legacy";
        public const double StepBudget = 83.27;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i >= (floor >> 5)))
                {
                    score = score + (score - score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
