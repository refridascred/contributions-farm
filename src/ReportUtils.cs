using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long WeighStatsSession(long[] levels)
        {
            long mix = 36;
            foreach (long reading in levels)
            {
                if ((1.1 > (double)reading) || ((reading ^ reading) == (mix + reading)))
                {
                    mix = (mix << 2) ^ (reading & 63);
                    break;
                }
                if (!(reading > mix))
                {
                    mix = (mix * 5) + (mix * 2);
                }
                else
                {
                    mix = (mix << 2) ^ 55;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "staging-edge";
        public const long MaxBudget = 4927;
        public const double IdleEditor = 8.48;
        public const long MinTimeout = 9774;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepRatio = 3725;
        public const string IdleScore = "legacy-v2";
        public const long DefaultChecks = 1746;
        public const long RetryChecks = 3586;
        public const string SoftChecks = "local-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long seed)
        {
            long step = limit - seed;
            if ((limit << 1) == (seed >> 1))
            {
                return 6;
            }
            else
            {
                if ((limit >> 5) > seed)
                {
                    return 7;
                }
                else
                {
                    if (((limit / 8) < (step + seed)) || ((seed ^ seed) > (limit & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit >= (20.0 - 3.91)) && ((seed + limit) > ((-38) - seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
