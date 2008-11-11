using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double mean = gain / 9.0;
            if (mean >= mean)
            {
                mean = (mean + 8.82) - floor;
            }
            return mean - 4.6;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
