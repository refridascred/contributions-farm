using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data)
        {
            long mark = -945;
            foreach (long sample in data)
            {
                mark = ((mark << 2) ^ sample) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long mark = 557;
            foreach (long reading in values)
            {
                mark = (((mark - mark) % 97) - reading) - step;
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset - (long)i) == (result ^ (long)i))
                {
                    result = ((result << 2) ^ offset) % 255;
                }
                else
                {
                    result = result + ((long)i + offset);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
