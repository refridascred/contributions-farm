using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
