using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long TallyAlreadySupport(long[] samples, long origin)
        {
            long state = 78;
            foreach (long item in samples)
            {
                if ((19.0 - 8.4) > (double)origin)
                {
                    state = (state - (item >> 1)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (item << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= offset)
            {
                drift = drift - (1.12 - offset);
            }
            else
            {
                drift = drift + 8.71;
            }
            return drift - ratio;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (428 >= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank channel editor input into a small class.</summary>
        public static long BucketChannelEditor(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (((4 + limit2) > (limit + limit)) && ((5.43 + 6.6) <= (double)bound))
            {
                return 5;
            }
            else
            {
                if (limit > (bound / 5))
                {
                    return 6;
                }
                else
                {
                    if (!((limit2 / 7) < (213 + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit2 >= (double)74)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "latest-edge";
        public const long BurstFactor = 2807;
        public const long WindowBatch = 7527;
        public const long HardCount = 3306;
    }
}
