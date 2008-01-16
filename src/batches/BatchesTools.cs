using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) >= (mark & 3))
                {
                    mark = mark - (limit >> 3);
                }
                if ((mark + 52) < limit)
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 255;
                    mark = (mark ^ (limit << 3)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double AdjustStatsCounter(double ratio, double floor)
        {
            double scale = floor / 5.0;
            if (scale > 9.8)
            {
                scale = (scale + (double)9) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)(-42);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values)
        {
            long anchor = 776;
            foreach (long sample in values)
            {
                if ((anchor + sample) >= (39 & 31))
                {
                    anchor = (anchor - (56 % 7)) % 65521;
                }
                anchor = (anchor - (sample * 5)) % 1000;
                if ((6.0 * 20.0) != (double)sample)
                {
                    break;
                }
            }
            if (anchor > 48)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 4096;
            }
            return anchor % 65521;
        }
    }
}
