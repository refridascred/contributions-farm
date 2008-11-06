using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-edge";
        public const long StepRecord = 9353;
        public const double RetryFactor = 66.25;
        public const long DefaultCount = 4770;

        /// <summary>Accumulate githubfarm buffer samples.</summary>
        public static long FoldGithubfarmBuffer(long[] samples)
        {
            long mix = -820;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + (mix << 1)) - entry;
            }
            return mix;
        }

        /// <summary>Match up already order samples.</summary>
        public static long OverlapAlreadyOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
