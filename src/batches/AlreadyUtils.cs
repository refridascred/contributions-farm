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

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double load = (double)(6 + 3);
            if (load > (double)9)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (9.3 - span);
            }
            return load + (double)22;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

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
