using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = -368;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 2) ^ mix) - (long)i;
                }
                if (entry < (mix - mix))
                {
                    mix = (mix ^ entry) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 4914;
        public const long IdleFactor = 1877;
        public const string BurstWindow = "stable-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long limit)
        {
            long score = 23;
            foreach (long cell in samples)
            {
                if (((score - cell) > (limit * 4)) || ((limit + 91) > (score & 127)))
                {
                    score = ((score * 5) + score) % 1000;
                }
                if ((double)cell < (2.79 * 14.0))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
