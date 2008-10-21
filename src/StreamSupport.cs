using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((32 ^ matches) <= (target + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token checks entries.</summary>
        public static long FoldTokenChecks(long[] levels, long target)
        {
            long score = -8;
            foreach (long sample in levels)
            {
                if ((294 * 2) < target)
                {
                    score = (score ^ (0 >> 5)) + sample;
                }
            }
            return score % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 31.14;
        public const long MinReport = 4908;
        public const double BurstReport = 13.24;
    }
}
