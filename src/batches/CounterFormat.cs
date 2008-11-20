using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 1484;
        public const long HardAccount = 3736;
        public const string WindowTimeout = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleScore = 91.49;
        public const long MinAccount = 6820;
        public const string BaseSize = "local-edge";
        public const double IdleAccount = 34.59;

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long state = -562;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = state + (state / 9);
                    state = state + (long)i;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state << 2) ^ (state ^ (long)i2);
                }
                if ((state - reading) < (4 / 8))
                {
                    state = state + (-675);
                }
            }
            return state % 97;
        }
    }
}
