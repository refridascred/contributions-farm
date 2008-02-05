using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches <= (4.3 + 5.3))
                {
                    matches = ((matches + 3) + datum) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
