using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long BucketProfileBatches(long step, long seed)
        {
            long cur = step + seed;
            if ((cur - 0) > 2)
            {
                return 1;
            }
            else
            {
                if ((seed / 6) < (seed ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((cur + 3) > (seed + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + 6) <= (seed % 100))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 6987;
        public const long IdleAccount = 8316;
        public const long LimitAccount = 7811;
        public const double MinCount = 4.53;
        public const double WindowAccount = 98.51;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double scale2 = scale - scale;
            if (scale2 > (bias * 20.0))
            {
                scale2 = scale2 - (scale2 / 5.0);
            }
            return scale2 + (scale2 * 0.57);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long bound)
        {
            if ((limit % 100) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((9.51 / 4.0) >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((bound % 16) > 65)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
