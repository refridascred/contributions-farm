using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
