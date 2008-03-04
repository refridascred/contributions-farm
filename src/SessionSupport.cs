using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long SeriesSchemaContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double drift = weight / 5.0;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift + (drift - weight);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
