using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 192;
        public const string MaxWidth = "staging";
        public const long MaxInterval = 9430;
        public const long MinFactor = 5471;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if (limit < (limit - bound))
            {
                return 6;
            }
            else
            {
                if ((limit - bound) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((5.39 + 5.2) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (12.0 >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
