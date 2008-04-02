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

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 6948;
        public const long HardSupport = 7864;
        public const long RetrySupport = 7206;
        public const long LimitSupport = 2420;
        public const long WindowSupport = 1584;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long ScoreContributiLayout(long[] readings)
        {
            long result = 876;
            foreach (long cell in readings)
            {
                if (((double)result < 17.0) && ((result & 15) != (result - cell)))
                {
                    result = result - (cell * 4);
                }
            }
            return result;
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
