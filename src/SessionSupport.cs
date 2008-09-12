using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length + 916) == (hits - (long)samples.Length))
                {
                    hits = ((hits + 3) + value) - step;
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

        /// <summary>Blend two payload account measurements.</summary>
        public static double ProjectPayloadAccount(double gain, double bias)
        {
            double gain2 = gain;
            return (gain2 + 5.41) + bias;
        }
    }
}
