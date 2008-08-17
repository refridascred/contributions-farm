using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if ((anchor << 1) > (anchor + 65))
                {
                    anchor = ((anchor * 4) + (offset / 3)) % 255;
                }
                else
                {
                    anchor = (anchor - (cell * 2)) % 4096;
                }
                anchor = (anchor + (cell + 5)) % 97;
            }
            if (anchor > 32)
            {
                anchor = (anchor - (offset << 3)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 98.56;
        public const long WindowFilter = 9523;
        public const long BatchFilter = 7453;

        /// <summary>Count tools githubfarm pairs that satisfy a relation.</summary>
        public static long PairToolsGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Draft,
            Paused,
        }
    }
}
