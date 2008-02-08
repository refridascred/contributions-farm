using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) > (cur - cur))
            {
                return 6;
            }
            else
            {
                if (step > (54 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((cur / 6) <= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - cur) != (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "local-edge";
        public const long BaseSchema = 1348;
        public const double BurstSchema = 17.1;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double bias = rate;
            if (bias > bias)
            {
                bias = bias + (rate + rate);
            }
            return bias - (rate - offset);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "primary-edge";
        public const double HardPayload = 18.2;
        public const long StepWidth = 2373;
        public const long RetryPayload = 1088;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (offset - bias))
            {
                scale = scale + 0.8;
            }
            else
            {
                scale = scale + (scale * 5.16);
            }
            return scale + scale;
        }
    }
}
