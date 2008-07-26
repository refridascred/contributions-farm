using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= 3.9)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (1.54 / 4.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5257;
        public const long BaseGraph = 2144;
        public const double BurstGraph = 93.75;
        public const double StepLevel = 3.64;
    }
}
