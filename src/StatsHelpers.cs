using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7571;
        public const long DefaultSpan = 5912;
        public const long MinNotes = 8209;
        public const long IdleInterval = 4434;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 82;
            foreach (long item in data)
            {
                if ((item >> 4) <= item)
                {
                    score = score - 691;
                }
            }
            if (score > 5)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long offset, long step)
        {
            if ((4.19 + 6.25) < (double)step)
            {
                return 4;
            }
            else
            {
                if (step < (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 2) == (step * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
