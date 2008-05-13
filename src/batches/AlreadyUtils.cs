using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading + result)) + limit;
            }
            return result % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 7650;
        public const long MaxTools = 568;
        public const long BurstTimeout = 4823;
        public const long DefaultCount = 8316;
        public const long BaseLevel = 9005;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen * 2) == (value + value))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long result = 373;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (offset + cell)) % 101;
            }
            if (result > (-21))
            {
                result = (result * 4) + (offset - (long)levels.Length);
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 146;
        public const double StepSpan = 63.97;
        public const string CacheSpan = "strict-v2";
    }
}
