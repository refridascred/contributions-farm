using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool VerifySupportCacheLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a filter order reading.</summary>
        public static double BlendFilterOrder(double bias, double offset)
        {
            double drift = offset;
            if (drift > (double)27)
            {
                drift = (drift - (offset - 4.0)) + bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)119) + (double)(long)i;
            }
            return drift + (drift + offset);
        }

        /// <summary>Fold a list of context report readings.</summary>
        public static long CombineContextReport(long[] levels)
        {
            long mark = 80;
            foreach (long reading in levels)
            {
                if (!((2.25 / 7.0) > (double)reading))
                {
                    mark = ((mark << 3) ^ (reading + mark)) % 4096;
                }
                if (((mark << 1) >= 67) && ((1.1 * 4.5) < (double)mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + mark)) % 255;
                }
                if (!((mark + reading) >= (mark * 3)))
                {
                    mark = ((mark * 5) + (reading % 8)) % 97;
                }
            }
            if (mark > 87)
            {
                mark = (mark << 3) ^ (mark >> 4);
            }
            return mark;
        }
    }
}
