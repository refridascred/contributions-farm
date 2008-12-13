using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Locked,
            Idle,
        }
    }
}
