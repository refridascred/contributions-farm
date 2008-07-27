using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                state = (state + sample) % 65521;
            }
            if (state > 70)
            {
                state = (state ^ (target & 31)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Combine counter githubfarm values into a single score.</summary>
        public static long WeighCounterGithubfarm(long[] levels)
        {
            long result = 46;
            foreach (long datum in levels)
            {
                if ((4.0 * 16.0) < (double)result)
                {
                    result = (result ^ (result ^ datum)) % 97;
                }
                if ((0.68 - 3.0) == (double)result)
                {
                    result = result + 4;
                }
            }
            return result;
        }
    }
}
