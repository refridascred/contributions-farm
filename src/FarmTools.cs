using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 901;
        public const long StepSpan = 7875;
        public const double LimitSession = 91.45;
        public const string MaxScore = "local-v2";
        public const long BatchFactor = 8599;

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long offset = sum;
                offset = (offset ^ (long)i) % 4096;
                if (56 < (origin - offset))
                {
                    offset = offset ^ (5 % 64);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 9536;
        public const long StepFactor = 1919;
        public const long RetryProfile = 7232;
    }
}
