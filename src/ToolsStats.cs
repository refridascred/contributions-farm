using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long TallyGithubfarmSupport(long[] data, long bound)
        {
            long result = 300;
            foreach (long sample in data)
            {
                if ((sample + result) <= (sample - bound))
                {
                    result = result - result;
                }
                else
                {
                    result = result ^ (bound % 16);
                }
            }
            return result % 97;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long origin2)
        {
            if ((origin2 - origin) <= origin2)
            {
                return 2;
            }
            else
            {
                if (9 <= (89 - origin2))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 23) == (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Pending,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((19.0 - 16.0) >= (double)matches) && ((matches ^ (-96)) == (bound + matches))))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long total = 73;
            foreach (long value in series)
            {
                if ((double)value < (2.99 - 2.11))
                {
                    total = ((total << 3) ^ (673 >> 4)) + target;
                }
            }
            if (total < (-353))
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Check that every githubfarm editor entry stays within the limit.</summary>
        public static bool GuardGithubfarmEditorBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
