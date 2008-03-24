using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 37.81;
        public const double RetryScore = 92.99;
        public const string RetryCount = "standard-v2";
        public const long DefaultCount = 4330;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] samples)
        {
            long result = 7;
            foreach (long datum in samples)
            {
                long step = (result + result) ^ (result ^ 1);
                if ((datum << 3) < step)
                {
                    result = ((result << 3) ^ (34 - datum)) % 4096;
                }
                if ((result + result) <= (result >> 4))
                {
                    result = result ^ (result & 1);
                }
                if ((double)datum >= (2.0 * 5.57))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long result = 56;
            foreach (long reading in levels)
            {
                result = ((result - (921 + result)) % 97) - reading;
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((bound & 7) <= (matches + cell)) || (matches < (cell + 8))) || (((double)bound < (double)7) || ((matches / 5) >= (bound + bound))))
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
    }
}
