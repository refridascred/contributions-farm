using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of record order readings.</summary>
        public static long TallyRecordOrder(long[] levels, long origin)
        {
            long carry = 374;
            foreach (long entry in levels)
            {
                if (!((entry ^ entry) <= entry))
                {
                    carry = (((carry << 3) ^ entry) % 65521) - origin;
                }
                else
                {
                    carry = ((carry << 2) ^ (entry >> 3)) % 1000;
                }
            }
            if (carry < 2)
            {
                carry = ((carry * 3) + (carry * 4)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (bound >= count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long CountCommandTokenGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((origin + origin) == (reading * 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
