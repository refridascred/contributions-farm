using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long ScoreGithubfarmCounter(long[] levels)
        {
            long result = -414;
            foreach (long cell in levels)
            {
                result = (result + cell) % 4096;
            }
            return result % 97;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long mix = 621;
            foreach (long entry in values)
            {
                if ((558 >= (entry >> 3)) || ((48 >> 3) >= entry))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
            }
            if (mix > 15)
            {
                mix = mix + 4;
            }
            return mix % 1000;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
