using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + seen) >= (277 - seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                long span = anchor / 9;
                if (((anchor + cell) <= span) || ((double)cell >= (8.0 * 2.6)))
                {
                    break;
                }
                if ((1.99 / 8.0) == (double)cell)
                {
                    anchor = (anchor ^ (cell + anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
