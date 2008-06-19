using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3348;
        public const string MaxTimeout = "staging-v2";
        public const long BaseDepth = 7423;
        public const double SoftFactor = 7.56;
        public const long StepMetric = 2251;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long carry = 47;
            foreach (long entry in values)
            {
                if ((6 * 3) != (carry / 8))
                {
                    carry = ((carry * 4) + carry) % 255;
                }
                if ((carry - entry) == (0 + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
