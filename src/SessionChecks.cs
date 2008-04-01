using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.14))
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 335;
        public const long StepSpan = 4800;
        public const long BaseFilter = 1136;
    }
}
