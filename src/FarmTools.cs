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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step >= mark) && ((double)step != (5.0 * 9.7)))
                {
                    mark = (mark - (120 + step)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 9536;
        public const long StepFactor = 1919;
        public const long RetryProfile = 7232;
    }
}
