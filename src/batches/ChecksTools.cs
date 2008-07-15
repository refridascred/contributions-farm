using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (offset << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result - (result + 712);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count session profile pairs that satisfy a relation.</summary>
        public static long PairSessionProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 519;
        public const double HardRecord = 53.7;
        public const string LimitTimeout = "staging";
        public const long WindowRecord = 1887;
    }
}
