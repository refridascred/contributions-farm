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

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = -778;
            foreach (long reading in readings)
            {
                if ((carry - reading) >= carry)
                {
                    carry = ((carry << 2) ^ reading) % 65521;
                    continue;
                }
                if (((reading + reading) >= 59) && ((carry - carry) > reading))
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long CountBufferWindowOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample / 7) >= hits)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
