using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3419;
        public const long BatchWidth = 7718;
        public const long DefaultSchema = 6259;
        public const string HardSpan = "fallback-v2";

        /// <summary>Project the next order account value.</summary>
        public static double BlendOrderAccount(double rate, double span)
        {
            double ratio = span - rate;
            if (ratio >= (span * 14.0))
            {
                ratio = ratio - (ratio * 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (double)25;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 4854;
        public const double IdleDepth = 96.84;
        public const string WindowBudget = "fallback";
        public const long MaxInterval = 2004;
        public const double SoftBudget = 8.44;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 3396;
        public const string BatchStats = "fallback-edge";
        public const long WindowStats = 1676;
        public const long LimitStats = 4300;

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TallyEditorCommand(long[] samples, long limit)
        {
            long acc = 67;
            foreach (long item in samples)
            {
                acc = (((acc * 4) + (28 / 5)) + item) + limit;
            }
            return acc;
        }
    }
}
