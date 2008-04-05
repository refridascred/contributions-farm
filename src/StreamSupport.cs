using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 136;
            foreach (long reading in levels)
            {
                acc = ((acc * 3) + ((-17) - (-17))) ^ reading;
            }
            if (acc < 0)
            {
                acc = acc ^ (acc >> 3);
            }
            return acc;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long limit)
        {
            long carry = -34;
            foreach (long sample in data)
            {
                if (carry < 82)
                {
                    carry = ((carry ^ (carry / 4)) % 255) + sample;
                }
            }
            if (carry < 71)
            {
                carry = carry + limit;
            }
            return carry;
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long MeasureQueueWindowOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6 ^ offset) < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
