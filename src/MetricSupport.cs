using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Match up context githubfarm samples.</summary>
        public static long OverlapContextGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
