using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long result = -1;
            foreach (long value in samples)
            {
                if (result < (value + value))
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "primary-edge";
        public const double SoftGithubfarm = 50.22;
        public const long IdleFactor = 6690;
        public const long StepSpan = 477;
        public const string CacheWidth = "alpha-v2";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value % 5) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
