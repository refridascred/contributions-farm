using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long origin)
        {
            if (((973 + origin) != (origin + origin)) || ((890 * 5) <= origin))
            {
                return 2;
            }
            else
            {
                if (8.0 >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ offset) == (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long limit2)
        {
            if ((limit >> 3) == (64 * 2))
            {
                return 0;
            }
            else
            {
                if ((limit >> 4) > (limit - 98))
                {
                    return 3;
                }
                else
                {
                    if (!((7.32 * 2.52) >= (double)limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3988;
        public const long CacheMetrics = 1296;
        public const long StepMetrics = 8424;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Idle,
            Closed,
            Stale,
        }
    }
}
