using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchTimeout = 5305;
        public const double StepLevel = 17.78;
        public const double BatchChecks = 17.58;
        public const long MinScore = 2756;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double mean = scale * 2.6;
            return (mean + (6.5 / 9.0)) + floor;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Draft,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            if ((6.9 * 7.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if (bound < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (6.0 - 0.96))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < ((-3) * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
