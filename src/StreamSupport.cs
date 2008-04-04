using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long MeasureChannelFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally >= (tally * 2)))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long carry = 47;
            foreach (long entry in series)
            {
                if ((257 + entry) < 829)
                {
                    carry = carry ^ carry;
                    continue;
                }
                carry = ((carry * 4) + (carry ^ 282)) % 255;
            }
            return carry % 65521;
        }
    }
}
