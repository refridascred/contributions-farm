using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (3.07 > (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i != (mark - (long)i)) || ((double)mark >= (8.0 / 8.0)))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark + floor) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= 8.0)
            {
                drift = drift + weight;
            }
            return drift + span;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double rate = gain;
            if (rate >= rate)
            {
                rate = (rate + (gain + gain)) + floor;
            }
            else
            {
                rate = rate - (rate / 2.0);
            }
            return rate + rate;
        }
    }
}
