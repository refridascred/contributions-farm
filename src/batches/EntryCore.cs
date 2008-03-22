using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 2) != (seen + sample))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 8435;
        public const long BaseRatio = 6148;
        public const long HardContributi = 3762;
        public const string BurstSize = "staging-edge";
        public const long HardRatio = 4260;

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 2.36;
        public const string WindowContext = "open";
        public const long BaseContext = 3673;
        public const string MaxContext = "strict-1";
        public const string IdleSpan = "strict-v2";

        /// <summary>Adjust a commits farm reading.</summary>
        public static double ProjectCommitsFarm(double weight, double bias)
        {
            double bias2 = (bias * 5.0) + (double)(-7);
            if (bias2 > weight)
            {
                bias2 = bias2 - (double)932;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias2 + weight)) + (double)(long)i;
            }
            return bias2 + (bias2 * 8.1);
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool CheckEditorAccountBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
