using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm editor readings against a rule.</summary>
        public static long CountGithubfarmEditorGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((0.8 - 20.0) == (double)offset)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 404;
            foreach (long datum in values)
            {
                if ((16 + datum) == (datum ^ datum))
                {
                    score = (score * 3) + (datum >> 4);
                }
                if ((datum - 702) == (782 + datum))
                {
                    break;
                }
            }
            if (score > 32)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 4096;
        }
    }
}
