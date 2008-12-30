using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(limit < (mix % 100)))
                {
                    mix = ((mix << 2) ^ (mix / 2)) % 4096;
                }
                mix = ((mix * 5) + limit) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool ValidateContributiRouteRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double bias = rate;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + (double)(-537);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (bias + bias);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
