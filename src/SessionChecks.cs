using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
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
