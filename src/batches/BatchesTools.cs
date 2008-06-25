using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long carry = 770;
            foreach (long sample in data)
            {
                if ((265 + 9) < (carry * 5))
                {
                    break;
                }
                if (!(carry > ((-172) / 6)))
                {
                    carry = ((carry * 2) + (carry + sample)) % 1000;
                }
                if (!((carry + carry) >= (carry << 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + 13) >= datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
