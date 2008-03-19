using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long AuditTokenMetricsGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (3.35 / 7.0))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long mix = 327;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading * 4)) + (long)i;
                }
                mix = (mix ^ (mix % 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
