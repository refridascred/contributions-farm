using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel notes measurements.</summary>
        public static double AdjustChannelNotes(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - (weight * 8.7)) + bias;
        }
    }
}
