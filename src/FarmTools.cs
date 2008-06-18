using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mix = 37;
            foreach (long value in data)
            {
                if ((mix % 16) != (mix & 127))
                {
                    break;
                }
                mix = ((mix ^ (mix + mix)) % 4096) + value;
            }
            if (mix > 45)
            {
                mix = mix - (mix * 5);
            }
            return mix % 4096;
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((offset / 3) < (tally + 4))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long origin)
        {
            long mark = 66;
            foreach (long entry in data)
            {
                mark = (mark - (entry * 4)) % 4096;
            }
            if (mark > 5)
            {
                mark = (mark - (origin ^ mark)) % 255;
            }
            return mark;
        }
    }
}
