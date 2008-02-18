using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((92 * 5) < count) || ((double)sample <= 5.53))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double scale = weight;
            if (scale > (6.34 - scale))
            {
                scale = scale - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (weight * 8.6)) - (double)(long)i;
            }
            return scale + 12.0;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)810)
            {
                drift = drift - drift;
            }
            return drift - (rate + span);
        }
    }
}
