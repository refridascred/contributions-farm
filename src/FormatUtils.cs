using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two farm commits measurements.</summary>
        public static double SmoothFarmCommits(double weight, double span)
        {
            double drift = 14.0 + (span + span);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (1.0 + weight)) + (double)(long)i;
            }
            return drift - (span - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9582;
        public const double HardRatio = 69.6;
        public const long MaxLevel = 6700;
        public const string MaxContext = "stable-v2";
        public const string BaseScore = "standard-v2";

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long RankRecordCounter(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((double)gap != (9.18 * 1.0))
            {
                return 4;
            }
            else
            {
                if (((-933) * 3) != (limit / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (17.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((limit + gap) == (floor + floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchWidth = 9787;
        public const long MaxFarm = 8683;
        public const string SoftScore = "alpha-v2";

        /// <summary>Scale a payload stats figure with a bias.</summary>
        public static double BlendPayloadStats(double gain, double span)
        {
            double bias = gain;
            if (bias < bias)
            {
                bias = bias + (span / 2.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)743) - (double)(long)i;
            }
            return bias - (gain - gain);
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
