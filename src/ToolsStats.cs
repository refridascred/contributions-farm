using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a route batches reading by value.</summary>
        public static long FindRouteBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context tools entry stays within the limit.</summary>
        public static bool ValidateContextToolsRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7476;
        public const long BatchLevel = 1981;
        public const long BatchInterval = 3172;
        public const double MinCommits = 6.67;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (double)65)
            {
                gain = (gain + (floor * 4.57)) + ratio;
            }
            return gain + (double)765;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values, long floor)
        {
            long mix = 1;
            foreach (long value in values)
            {
                if (((double)floor == (5.1 * 1.02)) || ((1.9 * 12.0) != (double)mix))
                {
                    mix = ((mix * 3) + (floor >> 5)) - value;
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ (333 - floor)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
