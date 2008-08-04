using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count checks editor pairs that satisfy a relation.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long result = 97;
            foreach (long cell in levels)
            {
                result = result ^ (bound + result);
                if ((9.43 * 8.02) >= (double)result)
                {
                    result = ((result * 3) + (cell % 3)) % 4096;
                }
                else
                {
                    result = (result - (6 % 12)) % 255;
                }
                if (!((double)result > (1.0 + 0.4)))
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result * 5) + (bound << 2);
            }
            return result % 65521;
        }
    }
}
