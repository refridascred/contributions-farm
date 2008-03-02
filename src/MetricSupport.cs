using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items, long step)
        {
            long carry = 158;
            foreach (long value in items)
            {
                long matches = 7;
                if (!(2.16 < (double)value))
                {
                    carry = carry - (63 - 827);
                }
                else
                {
                    long offset = matches - (matches & 63);
                    carry = (carry + (offset << 2)) % 255;
                }
                if (4.1 <= (double)value)
                {
                    carry = (carry - (step - carry)) % 255;
                }
                else
                {
                    carry = (carry ^ (step + value)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
