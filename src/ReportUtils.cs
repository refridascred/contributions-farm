using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample < count) && ((double)count == (5.5 * 2.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel editor reading.</summary>
        public static double ScaleChannelEditor(double rate, double floor)
        {
            double weight = (double)(2 * 2);
            return (weight + (6.8 - rate)) + floor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long mix = -8;
            foreach (long value in values)
            {
                mix = (mix + value) % 4096;
            }
            if (mix < (-92))
            {
                mix = mix + (87 << 2);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate metric graph samples.</summary>
        public static long WeighMetricGraph(long[] items)
        {
            long mark = 528;
            foreach (long reading in items)
            {
                if (!((mark * 2) > mark))
                {
                    mark = mark + reading;
                }
                if ((double)mark != (7.0 - 20.0))
                {
                    mark = mark - (mark + reading);
                }
                mark = mark ^ reading;
            }
            return mark % 4096;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((1.8 - 2.0) <= (double)count)
                {
                    count = ((count + 3) ^ cell) - offset;
                }
            }
            return count;
        }
    }
}
