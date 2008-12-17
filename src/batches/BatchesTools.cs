using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a stream queue sample.</summary>
        public static long LookupStreamQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (step << 2)) % 65521;
                if (!((89 + 6) <= carry))
                {
                    long span = (carry + carry) >> 4;
                    carry = (carry - (step + span)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 100) == (7 ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
