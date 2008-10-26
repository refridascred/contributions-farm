using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (seen + 480)) && (datum <= (seen / 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ acc) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
