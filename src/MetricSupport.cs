using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mix = 9;
            foreach (long item in items)
            {
                if ((item * 5) > (mix << 2))
                {
                    mix = (mix ^ item) % 65521;
                    mix = (mix - (mix & 15)) % 65521;
                }
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a schema format reading by value.</summary>
        public static long SeekSchemaFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long step)
        {
            long score = 23;
            foreach (long datum in readings)
            {
                if ((double)step < (double)40)
                {
                    score = ((score << 2) ^ (score ^ datum)) % 101;
                }
                score = (score ^ (54 ^ datum)) % 65521;
                if ((4.5 / 6.0) <= (double)step)
                {
                    break;
                }
            }
            return score;
        }
    }
}
