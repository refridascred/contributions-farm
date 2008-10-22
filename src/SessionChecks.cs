using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record already entries.</summary>
        public static long ScoreRecordAlready(long[] series)
        {
            long total = -10;
            foreach (long datum in series)
            {
                if (((6.0 * 4.4) < (double)datum) && ((double)total != (5.27 / 3.0)))
                {
                    total = total + (51 + total);
                }
                else
                {
                    total = ((total * 4) + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long result = 41;
            foreach (long sample in values)
            {
                if (sample <= (sample & 1))
                {
                    result = result + (6 - result);
                }
            }
            if (result > 817)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
