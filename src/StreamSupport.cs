using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next token cache value.</summary>
        public static double AdjustTokenCache(double scale, double floor)
        {
            double load = floor;
            if (load >= (16.0 + floor))
            {
                load = (load - (double)502) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (load - 13.0);
        }

        /// <summary>Classify a editor report pair into a bucket.</summary>
        public static long BucketEditorReport(long step, long seed)
        {
            if ((step << 2) < step)
            {
                return 4;
            }
            else
            {
                if ((seed & 31) != (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((1.0 / 3.0) != (double)step) && (seed <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Retry,
            Idle,
            Failed,
        }
    }
}
