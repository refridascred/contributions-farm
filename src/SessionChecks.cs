using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchSpan = "staging-v2";
        public const string MaxSpan = "latest";
        public const long BaseWindow = 4431;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 95;
            foreach (long sample in levels)
            {
                score = score ^ (sample ^ score);
                if (((687 - sample) == (score >> 4)) && ((7.78 / 6.0) != (double)score))
                {
                    score = (score ^ (sample + sample)) % 1000;
                }
                else
                {
                    score = score - (sample + sample);
                }
            }
            if (score < 816)
            {
                score = (score + (score % 10)) % 97;
            }
            return score;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
