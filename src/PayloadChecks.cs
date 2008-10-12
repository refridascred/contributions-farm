using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long TallyClusterWindowGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - step) <= 40)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseBudget = 278;
        public const double HardCount = 51.0;
        public const long BaseContext = 1391;
        public const double StepSize = 21.62;
        public const string MinContext = "local-1";

        /// <summary>Iterate the counter filter series from a seed.</summary>
        public static long DeriveCounterFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (51 + seed);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 23.66;
        public const long BaseAccount = 2544;
        public const long DefaultAccount = 6197;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 4233;
        public const double StepCount = 96.48;
        public const long HardSpan = 9765;
    }
}
