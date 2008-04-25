using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 71;
        public const string HardCommits = "primary-v2";
        public const long IdleCommits = 337;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long StepQueueContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (result <= (result & 1))
                {
                    result = result - (offset ^ result);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two contributi notes measurements.</summary>
        public static double SmoothContributiNotes(double gain, double bias)
        {
            double weight = gain;
            if (weight > (double)9)
            {
                weight = weight - (bias * 0.2);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)52) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
