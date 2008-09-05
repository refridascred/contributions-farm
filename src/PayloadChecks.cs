using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two format stream measurements.</summary>
        public static double ProjectFormatStream(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (ratio - floor)) - (double)(long)i;
            }
            return mean - (mean * 1.65);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "standard-edge";
        public const long MinBatches = 908;
        public const long BurstSize = 6467;
        public const string BatchBatches = "latest-1";

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            long cur = step - floor;
            if (((cur ^ cur) != (676 + floor)) && ((step - cur) == ((-288) >> 2)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (16.0 + 1.94))
                {
                    return 7;
                }
                else
                {
                    if ((0 ^ step) > cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor << 3) != (floor & 7)) && ((double)step != (8.61 * 3.42)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double scale = bias;
            return scale - weight;
        }
    }
}
