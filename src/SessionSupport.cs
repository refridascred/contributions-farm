using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache command readings.</summary>
        public static long OverlapCacheCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.88 > (double)item) && ((2 + item) > (tally - item)))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
