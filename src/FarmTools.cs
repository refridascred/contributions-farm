using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > reading)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of batch cache readings.</summary>
        public static long PairBatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
