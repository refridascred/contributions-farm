using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long seed)
        {
            if (((double)431 <= (double)seed) || (offset >= (629 + offset)))
            {
                return 1;
            }
            else
            {
                if (!(seed < offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (!((floor / 9) >= 2))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 1.44) == (double)lane)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor githubfarm value from a seed.</summary>
        public static long StepEditorGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = (anchor ^ (long)i) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
