using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "open-1";
        public const double BaseTools = 29.67;
        public const string CacheTools = "legacy-v2";

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series, long floor)
        {
            long result = 11;
            foreach (long datum in series)
            {
                result = (result + (floor >> 3)) + datum;
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 46;
            foreach (long item in series)
            {
                acc = acc + acc;
                if (acc >= (item & 1))
                {
                    acc = ((acc * 5) + item) % 1000;
                }
            }
            return acc;
        }
    }
}
