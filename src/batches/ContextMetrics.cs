using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long limit)
        {
            long score = 22;
            foreach (long datum in samples)
            {
                if (((-69) >> 3) >= datum)
                {
                    score = (score - (limit & 255)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ limit) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((9.0 - 20.0) == (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Fold a list of editor githubfarm readings.</summary>
        public static long DigestEditorGithubfarm(long[] data)
        {
            long total = 71;
            foreach (long cell in data)
            {
                if (((cell - cell) > (total ^ total)) && ((30 * 3) >= cell))
                {
                    total = (total ^ (1 & 255)) % 101;
                }
                if ((714 << 2) <= cell)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
